using System;
using System.Collections.Generic;
using System.Linq;

namespace THE_READING_ROOM;

public class Category
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
}

public class Book
{
    public int Id { get; set; }
    public string Isbn { get; set; } = "";
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; } = "";
}

public class SaleLine
{
    public string Isbn { get; set; } = "";
    public string Title { get; set; } = "";
    public decimal UnitPrice { get; set; }
    public int Qty { get; set; }
    public decimal LineTotal => UnitPrice * Qty;
}

public class SaleRecord
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Customer { get; set; } = "";
    public string Cashier { get; set; } = "";
    public List<SaleLine> Lines { get; set; } = new();
    public decimal Total => Lines.Sum(l => l.LineTotal);
}

public class ActivityEntry
{
    public DateTime When { get; set; }
    public string Text { get; set; } = "";
}