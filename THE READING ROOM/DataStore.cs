using System;
using System.Collections.Generic;
using System.Linq;

namespace THE_READING_ROOM;

// The one place where the app keeps its data (in memory for Phase 1).
public static class DataStore
{
    public static List<Book> Books { get; } = new();
    public static List<Category> Categories { get; } = new();
    public static List<SaleRecord> Sales { get; } = new();
    public static List<ActivityEntry> Activity { get; } = new();

    // A book with this many copies or fewer counts as "running low"
    public static int LowStockLevel { get; set; } = 5;

    private static int nextBookId = 1;
    private static int nextSaleId = 1;

    // Pages listen to this, so they refresh when anything changes
    public static event EventHandler? DataChanged;
    public static void RaiseChanged() => DataChanged?.Invoke(null, EventArgs.Empty);

    static DataStore()
    {
        LoadSample();
    }

    // ---------------- Figures for the dashboard ----------------
    public static int TotalTitles => Books.Count;
    public static int TotalCopies => Books.Sum(b => b.Quantity);
    public static int LowStockCount => Books.Count(b => b.Quantity <= LowStockLevel);

    public static List<Book> LowStockBooks() =>
        Books.Where(b => b.Quantity <= LowStockLevel)
             .OrderBy(b => b.Quantity).ThenBy(b => b.Title).ToList();

    public static decimal SoldThisMonth()
    {
        var now = DateTime.Now;
        return Sales.Where(s => s.Date.Year == now.Year && s.Date.Month == now.Month)
                    .Sum(s => s.Total);
    }

    public static List<ActivityEntry> TodayActivity() =>
        Activity.Where(a => a.When.Date == DateTime.Today)
                .OrderByDescending(a => a.When).ToList();

    // ---------------- Books ----------------
    public static Book? FindBook(int id) => Books.FirstOrDefault(b => b.Id == id);

    public static bool IsIsbnTaken(string isbn, int ignoreId = 0) =>
        Books.Any(b => b.Id != ignoreId &&
                       string.Equals(b.Isbn, isbn, StringComparison.OrdinalIgnoreCase));

    public static void AddBook(Book book)
    {
        book.Id = nextBookId++;
        Books.Add(book);
        Log("Added " + book.Title + " to " + book.Category);
        RaiseChanged();
    }

    public static void UpdateBook(Book updated)
    {
        var existing = FindBook(updated.Id);
        if (existing == null) return;
        existing.Isbn = updated.Isbn;
        existing.Title = updated.Title;
        existing.Author = updated.Author;
        existing.Category = updated.Category;
        existing.Price = updated.Price;
        existing.Quantity = updated.Quantity;
        existing.Description = updated.Description;
        Log("Updated " + existing.Title);
        RaiseChanged();
    }

    public static void DeleteBook(int id)
    {
        var book = FindBook(id);
        if (book == null) return;
        Books.Remove(book);
        Log("Removed " + book.Title);
        RaiseChanged();
    }

    // ---------------- Categories ----------------
    public static int BooksInCategory(string name) => Books.Count(b => b.Category == name);

    public static bool CategoryExists(string name, string? ignoreName = null) =>
        Categories.Any(c => string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase) &&
                            !string.Equals(c.Name, ignoreName, StringComparison.OrdinalIgnoreCase));

    public static void AddCategory(Category category)
    {
        Categories.Add(category);
        Log("Added category " + category.Name);
        RaiseChanged();
    }

    public static void UpdateCategory(string oldName, Category updated)
    {
        var existing = Categories.FirstOrDefault(c => c.Name == oldName);
        if (existing == null) return;
        existing.Name = updated.Name;
        existing.Description = updated.Description;
        foreach (var b in Books.Where(b => b.Category == oldName)) b.Category = updated.Name;
        RaiseChanged();
    }

    // Returns false when the category still has books
    public static bool DeleteCategory(string name)
    {
        if (BooksInCategory(name) > 0) return false;
        Categories.RemoveAll(c => c.Name == name);
        Log("Removed category " + name);
        RaiseChanged();
        return true;
    }

    // ---------------- Sales ----------------
    // Returns an error message, or null when the sale went through.
    // Each book should appear once in the lines.
    public static string? CompleteSale(string customer, string cashier,
                                       List<SaleLine> lines, out SaleRecord? record)
    {
        record = null;
        customer = string.IsNullOrWhiteSpace(customer) ? "Walk-in customer" : customer.Trim();
        if (lines.Count == 0) return "Add at least one book to the sale.";
        if (lines.Any(line => line.Qty <= 0 || line.UnitPrice < 0))
            return "Each sale line must have a positive quantity and a valid price.";

        // Validate grouped quantities so duplicate lines cannot oversell one book.
        var requestedByIsbn = lines.GroupBy(line => line.Isbn, StringComparer.OrdinalIgnoreCase)
                                   .ToDictionary(group => group.Key, group => group.Sum(line => line.Qty), StringComparer.OrdinalIgnoreCase);
        foreach (var request in requestedByIsbn)
        {
            var book = Books.FirstOrDefault(b => string.Equals(b.Isbn, request.Key, StringComparison.OrdinalIgnoreCase));
            if (book == null) return "A selected book is no longer in the catalogue.";
            if (request.Value > book.Quantity)
                return "Only " + book.Quantity + " copies of \"" + book.Title + "\" are in stock.";
        }

        foreach (var request in requestedByIsbn)
            Books.First(b => string.Equals(b.Isbn, request.Key, StringComparison.OrdinalIgnoreCase)).Quantity -= request.Value;

        record = new SaleRecord
        {
            Id = nextSaleId++,
            Date = DateTime.Now,
            Customer = customer,
            Cashier = cashier,
            Lines = lines.Select(line => new SaleLine { Isbn = line.Isbn, Title = line.Title, UnitPrice = line.UnitPrice, Qty = line.Qty }).ToList()
        };
        Sales.Add(record);
        foreach (var line in lines) Log("Sold " + line.Qty + " × " + line.Title);
        RaiseChanged();
        return null;
    }

    // ---------------- Sample data ----------------
    public static void ClearAllData()
    {
        Books.Clear(); Categories.Clear(); Sales.Clear(); Activity.Clear();
        nextBookId = 1; nextSaleId = 1;
        Log("Cleared all bookstore data");
        RaiseChanged();
    }

    public static void LoadSample()
    {
        Books.Clear(); Categories.Clear(); Sales.Clear(); Activity.Clear();
        nextBookId = 1; nextSaleId = 1;

        Categories.Add(new Category { Name = "Fiction", Description = "Novels and short stories" });
        Categories.Add(new Category { Name = "Fantasy", Description = "Worlds that never were" });
        Categories.Add(new Category { Name = "History", Description = "The past, told plainly" });
        Categories.Add(new Category { Name = "Amharic", Description = "Books in Amharic" });
        Categories.Add(new Category { Name = "Children", Description = "Picture books and early readers" });

        Seed("12173000002", "To Kill a Mockingbird", "Harper Lee", "Fiction", 450m, 100);
        Seed("23808393731", "The Hobbit", "J.R.R. Tolkien", "Fantasy", 520m, 3);
        Seed("2E700906529", "Oromay", "Bealu Girma", "Amharic", 380m, 4);
        Seed("31904455812", "The Great Gatsby", "F. Scott Fitzgerald", "Fiction", 410m, 0);
        Seed("45530987120", "Sapiens", "Yuval Noah Harari", "History", 780m, 5);
        Seed("50871234905", "Fikir Eske Mekabir", "Haddis Alemayehu", "Amharic", 320m, 22);
        Seed("61120045531", "The Black Swan", "Nassim Taleb", "History", 690m, 9);
        Seed("70011223344", "Harry Potter and the Philosopher's Stone", "J.K. Rowling", "Children", 600m, 18);
        Seed("80022334455", "Things Fall Apart", "Chinua Achebe", "Fiction", 360m, 12);
        Seed("90033445566", "Pride and Prejudice", "Jane Austen", "Fiction", 340m, 7);

        var now = DateTime.Now;
        var first = new DateTime(now.Year, now.Month, 1, 9, 30, 0);
        SeedSale(first.AddHours(1), ("12173000002", 3), ("45530987120", 2));
        SeedSale(first.AddHours(3), ("61120045531", 4));
        SeedSale(first.AddHours(5), ("70011223344", 5), ("50871234905", 6));
        SeedSale(first.AddHours(7), ("90033445566", 3), ("80022334455", 4));
        SeedSale(DateTime.Today.AddHours(14).AddMinutes(21), ("12173000002", 2));

        Activity.Add(new ActivityEntry { When = DateTime.Today.AddHours(11).AddMinutes(48), Text = "Added The Black Swan to History" });
        Activity.Add(new ActivityEntry { When = DateTime.Today.AddHours(13).AddMinutes(2), Text = "Sold 1 × Oromay" });
        Activity.Add(new ActivityEntry { When = DateTime.Today.AddHours(14).AddMinutes(21), Text = "Sold 2 × To Kill a Mockingbird" });

        RaiseChanged();
    }

    private static void Seed(string isbn, string title, string author, string category, decimal price, int qty)
    {
        Books.Add(new Book
        {
            Id = nextBookId++,
            Isbn = isbn,
            Title = title,
            Author = author,
            Category = category,
            Price = price,
            Quantity = qty
        });
    }

    private static void SeedSale(DateTime when, params (string Isbn, int Qty)[] items)
    {
        var lines = new List<SaleLine>();
        foreach (var item in items)
        {
            var b = Books.First(x => x.Isbn == item.Isbn);
            lines.Add(new SaleLine { Isbn = b.Isbn, Title = b.Title, UnitPrice = b.Price, Qty = item.Qty });
        }
        Sales.Add(new SaleRecord { Id = nextSaleId++, Date = when, Cashier = "cashier", Lines = lines });
    }

    private static void Log(string text) =>
        Activity.Add(new ActivityEntry { When = DateTime.Now, Text = text });
}