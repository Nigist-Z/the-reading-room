namespace THE_READING_ROOM;

internal static class PageUi
{
    internal static event Action<string>? StatusRequested;

    internal static void SetStatus(string message) => StatusRequested?.Invoke(message);

    internal static void Message(Control owner, string text, MessageBoxIcon icon = MessageBoxIcon.Information)
    {
        SetStatus(text);
        MessageBox.Show(owner.FindForm(), text, "The Reading Room", MessageBoxButtons.OK, icon);
    }
}

public sealed partial class frmCategories
{
    private string? editingName;
    private bool refreshing;

    public frmCategories()
    {
        InitializeComponent();
        deleteButton.Enabled = false;
        grid.SelectionChanged += (_, _) => LoadSelection(); addButton.Click += (_, _) => ClearEditor(); saveButton.Click += (_, _) => SaveCategory(); deleteButton.Click += (_, _) => DeleteCategory();
        DataStore.DataChanged += DataChanged; Disposed += (_, _) => DataStore.DataChanged -= DataChanged;
        RefreshGrid();
    }

    private void DataChanged(object? sender, EventArgs e)
    {
        if (IsDisposed) return;
        if (InvokeRequired) { BeginInvoke(RefreshGrid); return; }
        RefreshGrid();
    }

    private void RefreshGrid()
    {
        if (IsDisposed) return;
        refreshing = true;
        var selected = editingName;
        grid.DataSource = DataStore.Categories.OrderBy(c => c.Name).Select(c => new CategoryRow { Name = c.Name, Description = c.Description, Books = DataStore.BooksInCategory(c.Name) }).ToList();
        if (!string.IsNullOrWhiteSpace(selected))
            foreach (DataGridViewRow row in grid.Rows)
                if (row.DataBoundItem is CategoryRow item && item.Name == selected) { row.Selected = true; grid.CurrentCell = row.Cells[0]; break; }
        refreshing = false;
        if (grid.CurrentRow != null) LoadSelection();
    }

    private void LoadSelection()
    {
        if (refreshing || grid.CurrentRow?.DataBoundItem is not CategoryRow row) return;
        editingName = row.Name; nameBox.Text = row.Name; descriptionBox.Text = DataStore.Categories.FirstOrDefault(c => c.Name == row.Name)?.Description ?? "";
        countLabel.Text = $"Books in category: {row.Books}"; saveButton.Text = "Save changes"; deleteButton.Enabled = true;
    }

    private void ClearEditor()
    {
        editingName = null; grid.ClearSelection(); nameBox.Clear(); descriptionBox.Clear(); countLabel.Text = "New category";
        saveButton.Text = "Save category"; deleteButton.Enabled = false; nameBox.Focus();
    }

    private void SaveCategory()
    {
        string name = nameBox.Text.Trim();
        if (name.Length == 0) { PageUi.Message(this, "Enter a category name.", MessageBoxIcon.Warning); nameBox.Focus(); return; }
        if (DataStore.CategoryExists(name, editingName)) { PageUi.Message(this, "A category with that name already exists.", MessageBoxIcon.Warning); nameBox.Focus(); return; }
        var category = new Category { Name = name, Description = descriptionBox.Text.Trim() };
        if (editingName == null) DataStore.AddCategory(category); else DataStore.UpdateCategory(editingName, category);
        editingName = name; RefreshGrid(); PageUi.Message(this, "Category saved.");
    }

    private void DeleteCategory()
    {
        if (editingName == null) return;
        int count = DataStore.BooksInCategory(editingName);
        if (count > 0) { PageUi.Message(this, $"This category has {count} book(s). Move them to another category before deleting it.", MessageBoxIcon.Warning); return; }
        if (MessageBox.Show(FindForm(), $"Delete '{editingName}'?", "Delete category", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        DataStore.DeleteCategory(editingName); ClearEditor();
    }

    private sealed class CategoryRow { public string Name { get; set; } = ""; public string Description { get; set; } = ""; public int Books { get; set; } }
}

public sealed partial class frmSales
{
    private readonly Dictionary<int, int> basket = new();

    public frmSales()
    {
        InitializeComponent();
        searchBox.TextChanged += (_, _) => RefreshBooks();
        addButton.Click += (_, _) => AddSelected();
        booksGrid.CellDoubleClick += (_, _) => AddSelected();
        booksGrid.SelectionChanged += (_, _) => UpdateQuantityLimit();
        removeButton.Click += (_, _) => RemoveSelected();
        clearButton.Click += (_, _) => ClearSale();
        completeButton.Click += (_, _) => Complete();
        DataStore.DataChanged += DataChanged; Disposed += (_, _) => DataStore.DataChanged -= DataChanged;
        RefreshBooks(); RefreshBasket();
    }

    private void DataChanged(object? sender, EventArgs e) { if (IsDisposed) return; if (InvokeRequired) { BeginInvoke((Action)(() => { RefreshBooks(); RefreshBasket(); })); return; } RefreshBooks(); RefreshBasket(); }
    private void RefreshBooks()
    {
        var query = searchBox.Text.Trim();
        booksGrid.DataSource = DataStore.Books.Where(b => b.Quantity > 0 && (query.Length == 0 || b.Title.Contains(query, StringComparison.OrdinalIgnoreCase) || b.Author.Contains(query, StringComparison.OrdinalIgnoreCase) || b.Isbn.Contains(query, StringComparison.OrdinalIgnoreCase)))
            .OrderBy(b => b.Title).Select(b => new BookPick { Id = b.Id, Title = b.Title, Author = b.Author, ISBN = b.Isbn, PriceETB = b.Price, InStock = b.Quantity }).ToList();
        emptySearchLabel.Visible = booksGrid.Rows.Count == 0;
        if (booksGrid.Rows.Count == 0 && query.Length > 0) PageUi.SetStatus("No available books match the search");
    }
    private void RefreshBasket()
    {
        foreach (int id in basket.Keys.Where(id => DataStore.FindBook(id) == null).ToList()) basket.Remove(id);
        basketGrid.DataSource = basket.Select(pair => { var b = DataStore.FindBook(pair.Key)!; return new BasketRow { Id = b.Id, Title = b.Title, Quantity = pair.Value, UnitPrice = b.Price, LineTotal = b.Price * pair.Value }; }).ToList();
        emptyBasketLabel.Visible = basket.Count == 0;
        totalLabel.Text = $"Total: {basket.Sum(pair => (DataStore.FindBook(pair.Key)?.Price ?? 0) * pair.Value):N2} ETB";
    }
    private void UpdateQuantityLimit()
    {
        if (booksGrid.CurrentRow?.DataBoundItem is not BookPick selected)
        {
            addButton.Enabled = false;
            return;
        }
        addButton.Enabled = true;
        quantityBox.Maximum = Math.Max(1, selected.InStock);
        if (quantityBox.Value > quantityBox.Maximum) quantityBox.Value = quantityBox.Maximum;
    }

    private void ClearSale()
    {
        if (basket.Count == 0 && string.IsNullOrWhiteSpace(customerBox.Text)) return;
        if (MessageBox.Show(FindForm(), "Clear all books and the customer name from this sale?", "Clear sale",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        basket.Clear(); customerBox.Clear(); RefreshBasket(); PageUi.SetStatus("Sale cleared");
    }

    private void AddSelected()
    {
        if (booksGrid.CurrentRow?.DataBoundItem is not BookPick selected) return;
        var book = DataStore.FindBook(selected.Id); if (book == null) return;
        int next = basket.GetValueOrDefault(book.Id) + (int)quantityBox.Value;
        if (next > book.Quantity) { PageUi.Message(this, $"Only {book.Quantity} copies of '{book.Title}' are in stock.", MessageBoxIcon.Warning); return; }
        basket[book.Id] = next; RefreshBasket(); PageUi.SetStatus($"Added {quantityBox.Value} x {book.Title} to the sale");
    }
    private void RemoveSelected() { if (basketGrid.CurrentRow?.DataBoundItem is BasketRow row) { basket.Remove(row.Id); RefreshBasket(); PageUi.SetStatus($"Removed {row.Title} from the sale"); } }
    private void Complete()
    {
        var lines = basket.Select(pair => { var book = DataStore.FindBook(pair.Key)!; return new SaleLine { Isbn = book.Isbn, Title = book.Title, UnitPrice = book.Price, Qty = pair.Value }; }).ToList();
        string? error = DataStore.CompleteSale(customerBox.Text, Session.UserName, lines, out var sale);
        if (error != null) { PageUi.Message(this, error, MessageBoxIcon.Warning); return; }
        basket.Clear(); customerBox.Clear(); RefreshBasket(); RefreshBooks();
        string receiptLines = string.Join(Environment.NewLine, sale!.Lines.Select(line => $"{line.Title} x{line.Qty}  {line.LineTotal:N2} ETB"));
        PageUi.Message(this, $"Sale #{sale.Id}  {sale.Date:g}{Environment.NewLine}{Environment.NewLine}{receiptLines}{Environment.NewLine}{Environment.NewLine}TOTAL  {sale.Total:N2} ETB{Environment.NewLine}{Environment.NewLine}Sale saved. Stock has been updated.");
    }
    private sealed class BookPick { public int Id { get; set; } public string Title { get; set; } = ""; public string Author { get; set; } = ""; public string ISBN { get; set; } = ""; public decimal PriceETB { get; set; } public int InStock { get; set; } }
    private sealed class BasketRow { public int Id { get; set; } public string Title { get; set; } = ""; public int Quantity { get; set; } public decimal UnitPrice { get; set; } public decimal LineTotal { get; set; } }
}

public sealed partial class frmReports
{
    public frmReports()
    {
        InitializeComponent();
        fromDate.Value = DateTime.Today.AddDays(-30);
        toDate.Value = DateTime.Today;
        fromDate.ValueChanged += (_, _) => RefreshReport();
        toDate.ValueChanged += (_, _) => RefreshReport();
        exportButton.Click += (_, _) => ExportCsv();
        DataStore.DataChanged += DataChanged;
        Disposed += (_, _) => DataStore.DataChanged -= DataChanged;
        RefreshReport();
    }

    private void DataChanged(object? sender, EventArgs e)
    {
        if (IsDisposed) return;
        if (InvokeRequired) { BeginInvoke(RefreshReport); return; }
        RefreshReport();
    }

    private List<SaleRecord> SalesInRange() => DataStore.Sales
        .Where(sale => sale.Date.Date >= fromDate.Value.Date && sale.Date.Date <= toDate.Value.Date)
        .OrderByDescending(sale => sale.Date).ToList();

    private void RefreshReport()
    {
        if (fromDate.Value.Date > toDate.Value.Date)
        {
            summary.Text = "Choose a date range where From is on or before To.";
            salesGrid.DataSource = new List<SaleRow>();
        }
        else
        {
            var sales = SalesInRange();
            summary.Text = $"Titles: {DataStore.TotalTitles:N0}     Low-stock titles: {DataStore.LowStockCount:N0}     {sales.Count:N0} sales in period     {sales.Sum(s => s.Lines.Sum(line => line.Qty)):N0} books     {sales.Sum(s => s.Total):N2} ETB";
            salesGrid.DataSource = sales.Select(sale => new SaleRow { Sale = sale.Id, Date = sale.Date.ToString("g"), Customer = sale.Customer, Cashier = sale.Cashier, Items = sale.Lines.Sum(line => line.Qty), TotalETB = sale.Total }).ToList();
        }
        allBooksList.BeginUpdate();
        allBooksList.Items.Clear();
        foreach (var book in DataStore.Books.OrderBy(book => book.Title))
        {
            var item = new ListViewItem(book.Isbn); item.SubItems.Add(book.Title); item.SubItems.Add(book.Author);
            item.SubItems.Add(book.Category); item.SubItems.Add(book.Price.ToString("N2")); item.SubItems.Add(book.Quantity.ToString());
            allBooksList.Items.Add(item);
        }
        allBooksList.EndUpdate();
        lowList.BeginUpdate();
        lowList.Items.Clear();
        foreach (var book in DataStore.LowStockBooks())
        {
            var item = new ListViewItem(book.Title);
            item.SubItems.Add(book.Author);
            item.SubItems.Add(book.Category);
            item.SubItems.Add(book.Quantity.ToString());
            lowList.Items.Add(item);
        }
        lowList.EndUpdate();
    }

    private void ExportCsv()
    {
        if (fromDate.Value.Date > toDate.Value.Date)
        {
            PageUi.Message(this, "Choose a valid date range before exporting.", MessageBoxIcon.Warning);
            return;
        }
        using var dialog = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv", FileName = $"ReadingRoom_Sales_{DateTime.Today:yyyy-MM-dd}.csv", Title = "Export sales report" };
        if (dialog.ShowDialog(FindForm()) != DialogResult.OK) return;
        try
        {
            var lines = new List<string> { "Sale,Date,Customer,Cashier,Books,Total ETB" };
            foreach (var sale in SalesInRange())
                lines.Add(string.Join(",", Csv(sale.Id.ToString()), Csv(sale.Date.ToString("g")), Csv(sale.Customer), Csv(sale.Cashier), Csv(sale.Lines.Sum(line => line.Qty).ToString()), Csv(sale.Total.ToString("0.00"))));
            File.WriteAllLines(dialog.FileName, lines, System.Text.Encoding.UTF8);
            PageUi.Message(this, $"Exported {lines.Count - 1} sale record(s).", MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            PageUi.Message(this, $"The report could not be exported: {ex.Message}", MessageBoxIcon.Error);
        }
    }

    private static string Csv(string value) => "\"" + value.Replace("\"", "\"\"") + "\"";

    private sealed class SaleRow
    {
        public int Sale { get; set; }
        public string Date { get; set; } = "";
        public string Customer { get; set; } = "";
        public string Cashier { get; set; } = "";
        public int Items { get; set; }
        public decimal TotalETB { get; set; }
    }
}

public sealed partial class frmSettings
{
    public frmSettings()
    {
        InitializeComponent();
        threshold.Value = Math.Clamp(DataStore.LowStockLevel, (int)threshold.Minimum, (int)threshold.Maximum);
        save.Click += (_, _) => { DataStore.LowStockLevel = (int)threshold.Value; DataStore.RaiseChanged(); PageUi.Message(this, "Settings saved."); };
        loadSample.Click += (_, _) =>
        {
            if (MessageBox.Show(FindForm(), "Replace the current in-memory books, categories, and sales with the sample set?", "Load sample books", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            DataStore.LoadSample(); PageUi.Message(this, "Sample books loaded.");
        };
        clearAll.Click += (_, _) =>
        {
            if (MessageBox.Show(FindForm(), "Clear all books, categories, sales, and activity from memory? This cannot be undone after you close this window.", "Clear all data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            DataStore.ClearAllData(); PageUi.Message(this, "All bookstore data was cleared.");
        };
    }
}
