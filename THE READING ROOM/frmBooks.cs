using System.ComponentModel;

namespace THE_READING_ROOM;

public partial class frmBooks : Form
{
    private readonly BindingSource booksSource = new();
    private List<Book> visibleBooks = new();

    public frmBooks()
    {
        InitializeComponent();

        cmbStock.Items.AddRange(new object[] { "Any stock", "In stock", "Low stock", "Out of stock" });
        cmbStock.SelectedIndex = 0;
        cmbCategory.SelectedIndexChanged += (_, _) => RefreshBooks();
        cmbStock.SelectedIndexChanged += (_, _) => RefreshBooks();
        txtSearch.TextChanged += (_, _) => RefreshBooks();
        dgvBooks.SelectionChanged += (_, _) => UpdateSelectedBook();
        btnAddBook.Click += (_, _) => AddBook();
        btnEditSelected.Click += (_, _) => EditSelectedBook();
        btnDeleteSelected.Click += (_, _) => DeleteSelectedBook();
        btnSellSelected.Click += (_, _) => SellSelectedBook();

        DataStore.DataChanged += DataStore_DataChanged;
        Disposed += (_, _) => DataStore.DataChanged -= DataStore_DataChanged;
        RefreshCategories();
        RefreshBooks();
    }

    private void DataStore_DataChanged(object? sender, EventArgs e)
    {
        if (IsDisposed) return;
        if (InvokeRequired)
        {
            BeginInvoke(RefreshAll);
            return;
        }
        RefreshAll();
    }

    private void RefreshAll()
    {
        RefreshCategories();
        RefreshBooks();
    }

    private void RefreshCategories()
    {
        string? selected = cmbCategory.SelectedItem as string;
        cmbCategory.BeginUpdate();
        cmbCategory.Items.Clear();
        cmbCategory.Items.Add("All categories");
        foreach (var category in DataStore.Categories.OrderBy(c => c.Name))
            cmbCategory.Items.Add(category.Name);
        cmbCategory.SelectedItem = selected != null && cmbCategory.Items.Contains(selected)
            ? selected : "All categories";
        cmbCategory.EndUpdate();
    }

    private void RefreshBooks()
    {
        string search = txtSearch.Text.Trim();
        string category = cmbCategory.SelectedItem as string ?? "All categories";
        string stock = cmbStock.SelectedItem as string ?? "Any stock";

        visibleBooks = DataStore.Books
            .Where(book => category == "All categories" || book.Category == category)
            .Where(book => stock switch
            {
                "In stock" => book.Quantity > DataStore.LowStockLevel,
                "Low stock" => book.Quantity > 0 && book.Quantity <= DataStore.LowStockLevel,
                "Out of stock" => book.Quantity == 0,
                _ => true
            })
            .Where(book => search.Length == 0 || book.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                           book.Author.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                           book.Isbn.Contains(search, StringComparison.OrdinalIgnoreCase))
            .OrderBy(book => book.Title)
            .ToList();

        dgvBooks.AutoGenerateColumns = false;
        dgvBooks.DataSource = booksSource;
        booksSource.DataSource = visibleBooks.Select(book => new BookGridRow
        {
            Id = book.Id,
            Isbn = book.Isbn,
            Title = book.Title,
            Author = book.Author,
            Category = book.Category,
            Price = book.Price,
            Quantity = book.Quantity,
            Status = book.Quantity == 0 ? "Out of stock" :
                     book.Quantity <= DataStore.LowStockLevel ? "Low stock" : "In stock"
        }).ToList();
        lblBookCount.Text = visibleBooks.Count == 0
            ? DataStore.Books.Count == 0 ? "Your shelves are empty. Add a book to start the catalogue." : "No books found. Try another search or adjust the filters."
            : $"Showing {visibleBooks.Count} of {DataStore.Books.Count} books";
        if (visibleBooks.Count == 0)
            PageUi.SetStatus(DataStore.Books.Count == 0 ? "No books in catalogue" : "No books match the current filters");

        if (dgvBooks.Rows.Count > 0)
            dgvBooks.Rows[0].Selected = true;
        UpdateSelectedBook();
    }

    private Book? GetSelectedBook()
    {
        if (dgvBooks.CurrentRow?.DataBoundItem is not BookGridRow row) return null;
        return DataStore.FindBook(row.Id);
    }

    private void UpdateSelectedBook()
    {
        var book = GetSelectedBook();
        bool hasBook = book != null;
        btnEditSelected.Enabled = hasBook;
        btnDeleteSelected.Enabled = hasBook;
        btnSellSelected.Enabled = hasBook && book!.Quantity > 0;
        if (book == null)
        {
            lblSelectedTitle.Text = "Select a book";
            lblSelectedAuthor.Text = "";
            lblSelectedIsbn.Text = "";
            lblSelectedCategory.Text = "";
            lblSelectedPrice.Text = "";
            lblSelectedQuantity.Text = "";
            return;
        }

        lblSelectedTitle.Text = book.Title;
        lblSelectedAuthor.Text = book.Author;
        lblSelectedIsbn.Text = book.Isbn;
        lblSelectedCategory.Text = book.Category;
        lblSelectedPrice.Text = $"{book.Price:N2} ETB";
        lblSelectedQuantity.Text = book.Quantity.ToString();
    }

    private void AddBook()
    {
        using var dialog = new BookEditorForm();
        if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;
        if (DataStore.IsIsbnTaken(dialog.BookValue.Isbn))
        {
            MessageBox.Show(FindForm(), "That ISBN is already in the catalogue.", "Duplicate ISBN",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        DataStore.AddBook(dialog.BookValue);
    }

    private void EditSelectedBook()
    {
        var existing = GetSelectedBook();
        if (existing == null) return;
        using var dialog = new BookEditorForm(existing);
        if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;
        if (DataStore.IsIsbnTaken(dialog.BookValue.Isbn, existing.Id))
        {
            MessageBox.Show(FindForm(), "That ISBN is already in the catalogue.", "Duplicate ISBN",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        dialog.BookValue.Id = existing.Id;
        DataStore.UpdateBook(dialog.BookValue);
    }

    private void DeleteSelectedBook()
    {
        var book = GetSelectedBook();
        if (book == null) return;
        if (MessageBox.Show(FindForm(), $"Delete ‘{book.Title}’ from the catalogue?", "Delete book",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            DataStore.DeleteBook(book.Id);
    }

    private void SellSelectedBook()
    {
        var book = GetSelectedBook();
        if (book == null || book.Quantity < 1) return;
        using var dialog = new BookSaleForm(book);
        if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;

        var line = new SaleLine { Isbn = book.Isbn, Title = book.Title, UnitPrice = book.Price, Qty = dialog.Quantity };
        string? error = DataStore.CompleteSale(dialog.Customer, Session.UserName, new List<SaleLine> { line }, out _);
        if (error != null)
            MessageBox.Show(FindForm(), error, "Sale not completed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private sealed class BookGridRow
    {
        public int Id { get; set; }
        public string Isbn { get; set; } = "";
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; } = "";
    }
}
