namespace THE_READING_ROOM;

public partial class BookEditorForm : Form
{
    public Book BookValue { get; private set; } = new();
    private readonly Book? original;

    public BookEditorForm(Book? book = null)
    {
        original = book;
        InitializeComponent();
        cmbCategory.Items.AddRange(DataStore.Categories.Select(category => category.Name).ToArray());
        if (cmbCategory.Items.Count == 0)
            cmbCategory.Items.Add("Uncategorized");

        if (book != null)
        {
            Text = "Edit book";
            txtIsbn.Text = book.Isbn;
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            cmbCategory.SelectedItem = book.Category;
            if (cmbCategory.SelectedIndex < 0 && !cmbCategory.Items.Contains(book.Category))
                cmbCategory.Items.Add(book.Category);
            cmbCategory.SelectedItem = book.Category;
            numPrice.Value = Math.Clamp(book.Price, numPrice.Minimum, numPrice.Maximum);
            numQuantity.Value = Math.Clamp(book.Quantity, (int)numQuantity.Minimum, (int)numQuantity.Maximum);
            txtDescription.Text = book.Description;
        }
        else
        {
            Text = "Add book";
            cmbCategory.SelectedIndex = 0;
        }
        btnSave.Click += (_, _) => SaveBook();
        btnCancel.Click += (_, _) => { DialogResult = DialogResult.Cancel; Close(); };
    }

    private void SaveBook()
    {
        string isbn = txtIsbn.Text.Trim();
        string title = txtTitle.Text.Trim();
        string author = txtAuthor.Text.Trim();
        if (isbn.Length == 0 || title.Length == 0 || author.Length == 0 || cmbCategory.SelectedItem == null)
        {
            MessageBox.Show(this, "Enter the ISBN, title, author, and category.", "Required information",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        BookValue = new Book
        {
            Id = original?.Id ?? 0,
            Isbn = isbn,
            Title = title,
            Author = author,
            Category = cmbCategory.SelectedItem.ToString() ?? "",
            Price = numPrice.Value,
            Quantity = (int)numQuantity.Value,
            Description = txtDescription.Text.Trim()
        };
        DialogResult = DialogResult.OK;
        Close();
    }
}
