using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;

namespace THE_READING_ROOM;

public partial class frmDashboard : Form
{
    // Tells frmMain when a button or link wants to open another page
    public event Action<string>? NavigateRequested;

    // ---- colours from the design ----
    private static readonly Color Paper = Color.FromArgb(234, 225, 209);
    private static readonly Color Cream = Color.FromArgb(244, 238, 225);
    private static readonly Color Rule = Color.FromArgb(201, 181, 142);
    private static readonly Color Ink = Color.FromArgb(58, 46, 36);
    private static readonly Color Soft = Color.FromArgb(107, 91, 75);
    private static readonly Color Gold = Color.FromArgb(138, 90, 18);
    private static readonly Color Wood = Color.FromArgb(90, 67, 49);
    private static readonly Color Red = Color.FromArgb(155, 54, 38);


    private sealed record Spine(string Title, int Copies, Color Color, float Height);

    private readonly List<Rectangle> spineRects = new();
    private int hoverIndex = -1;
    private int shelfLift;

    public frmDashboard()
    {
        InitializeComponent();
        tmrShelfMotion.Tick += tmrShelfMotion_Tick;

        lblCapDate.Text = DateTime.Now.ToString("dddd, d MMMM");
        // The photo strip behind the caption card
        pnlBanner.BackgroundImage = Properties.Resources.dashboard_banner;
        pnlBanner.BackgroundImageLayout = ImageLayout.Center;
        pnlBanner.BackColor = Color.FromArgb(59, 45, 34);
        // Smooth drawing for the three hand-drawn panels
        foreach (var p in new Control[] { pnlLedger, pnlShelf, pnlReceipt })
        {
            EnableDoubleBuffer(p);
            p.Resize += (s, e) => p.Invalidate();
        }

        pnlLedger.Paint += PaintLedger;
        pnlShelf.Paint += PaintShelf;
        pnlReceipt.Paint += PaintReceipt;

        pnlShelf.MouseMove += ShelfMouseMove;
        pnlShelf.MouseLeave += (s, e) => SetHover(-1);
        pnlShelf.MouseClick += (s, e) =>
        {
            if (hoverIndex >= 0) NavigateRequested?.Invoke("Books");
        };

        lnkViewAll.LinkClicked += (s, e) => NavigateRequested?.Invoke("Books");
        btnAddBook.Click += (s, e) => NavigateRequested?.Invoke("Books");
        btnRecordSale.Click += (s, e) => NavigateRequested?.Invoke("Sales");
        btnOpenReports.Click += (s, e) => NavigateRequested?.Invoke("Reports");

        // The banner picture is set here so it can never be lost from the designer
        pnlBanner.BackgroundImage = Properties.Resources.dashboard_banner;
        pnlBanner.BackgroundImageLayout = ImageLayout.Center;

        // Keep "View all 8" fully visible in the top right of the shelf panel
        lnkViewAll.AutoSize = true;
        lnkViewAll.Top = 18;
        pnlShelf.Resize += (s, e) => PlaceViewAll();
        PlaceViewAll();
    }
    private void DataStore_DataChanged(object? sender, EventArgs e)
    {
        if (IsDisposed) return;
        if (InvokeRequired) { BeginInvoke(RefreshDashboard); return; }
        RefreshDashboard();
    }

    private void RefreshDashboard()
    {
        pnlLedger.Invalidate();
        pnlShelf.Invalidate();
        pnlReceipt.Invalidate();
    }

    private void PlaceViewAll()
    {
        lnkViewAll.Left = pnlShelf.ClientSize.Width - lnkViewAll.Width - 20;
        lnkViewAll.BringToFront();
    }
    private static void EnableDoubleBuffer(Control c)
    {
        typeof(Control)
            .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(c, true);
    }

    // =====================================================================
    //  Shop figures: the "contents page" ledger with the gold ribbon
    // =====================================================================
    private void PaintLedger(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        var r = pnlLedger.ClientRectangle;
        if (r.Width < 200 || r.Height < 60) return;

        g.Clear(Cream);
        using var inkBrush = new SolidBrush(Ink);
        using var softBrush = new SolidBrush(Soft);
        using var rulePen = new Pen(Rule);
        g.DrawRectangle(rulePen, 0, 0, r.Width - 1, r.Height - 1);

        int split = (int)(r.Width * 0.454);
        g.DrawLine(rulePen, split, 12, split, r.Height - 12);

        // Left: the big figure
        using var small = new Font("Segoe UI", 9.5f);
        using var big = new Font("Georgia", 30f, FontStyle.Bold);
        using var etb = new Font("Georgia", 13f);
        g.DrawString("Sold this month", small, softBrush, 28, 14);
        string soldThisMonth = DataStore.SoldThisMonth().ToString("N0");
        g.DrawString(soldThisMonth, big, inkBrush, 24, 32);
        SizeF bigSize = g.MeasureString(soldThisMonth, big);
        g.DrawString("ETB", etb, softBrush, 24 + bigSize.Width - 8, 32 + 26);
        g.DrawString("Month to date", small, softBrush, 28, r.Height - 30);

        // Right: the three lines with dotted leaders
        int left = split + 28, right = r.Width - 28;
        var figures = new (string Label, string Value, bool Warn)[]
        {
            ("Titles", DataStore.TotalTitles.ToString("N0"), false),
            ("Copies on the shelves", DataStore.TotalCopies.ToString("N0"), false),
            ("Running low", DataStore.LowStockCount.ToString("N0"), true),
        };
        int rowH = 30, y0 = (r.Height - rowH * figures.Length) / 2;
        using var labelFont = new Font("Segoe UI", 11f);
        using var numFont = new Font("Georgia", 15f, FontStyle.Bold);
        using var dots = new Pen(Rule, 1.6f) { DashStyle = DashStyle.Dot };

        for (int i = 0; i < figures.Length; i++)
        {
            var f = figures[i];
            int y = y0 + i * rowH;
            SizeF ls = g.MeasureString(f.Label, labelFont);
            SizeF ns = g.MeasureString(f.Value, numFont);
            using var valueBrush = new SolidBrush(f.Warn ? Gold : Ink);

            g.DrawString(f.Label, labelFont, inkBrush, left, y + 4);
            g.DrawString(f.Value, numFont, valueBrush, right - ns.Width + 4, y);
            float lineY = y + 22;
            g.DrawLine(dots, left + ls.Width + 8, lineY, right - ns.Width - 4, lineY);
        }

        // The gold bookmark ribbon
        using var goldBrush = new SolidBrush(Gold);
        g.FillPolygon(goldBrush, new[]
        {
            new Point(split - 10, 0), new Point(split + 10, 0),
            new Point(split + 10, 54), new Point(split, 44), new Point(split - 10, 54)
        });
    }

    // =====================================================================
    //  Needs reordering: a small bookshelf
    // =====================================================================
    private void PaintShelf(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        var r = pnlShelf.ClientRectangle;
        if (r.Width < 200 || r.Height < 120) return;

        using (var bg = new LinearGradientBrush(r, Color.FromArgb(239, 230, 211), Color.FromArgb(231, 220, 196), 90f))
            g.FillRectangle(bg, r);
        using (var border = new Pen(Rule))
            g.DrawRectangle(border, 0, 0, r.Width - 1, r.Height - 1);

        using var inkBrush = new SolidBrush(Ink);
        using var softBrush = new SolidBrush(Soft);
        using var redBrush = new SolidBrush(Red);
        using var creamBrush = new SolidBrush(Cream);
        using (var headFont = new Font("Georgia", 14f, FontStyle.Bold))
            g.DrawString("Needs reordering", headFont, inkBrush, 20, 14);

        int plankH = 10, tagsH = 46;
        int plankTop = r.Height - tagsH - plankH - 6;
        int maxH = plankTop - 60;
        int w = 62, gap = 10, x = 24;

        spineRects.Clear();
        using var titleFont = new Font("Georgia", 9.5f, FontStyle.Bold);
        using var tagNum = new Font("Georgia", 13f, FontStyle.Bold);
        using var tagTxt = new Font("Segoe UI", 8.5f);
        using var bandPen = new Pen(Color.FromArgb(201, 162, 74), 2f);

        var spines = DataStore.LowStockBooks().Take(4)
            .Select((book, index) => new Spine(book.Title, book.Quantity,
                new[] { Color.FromArgb(142, 59, 46), Color.FromArgb(110, 79, 125), Color.FromArgb(123, 90, 62), Color.FromArgb(90, 105, 70) }[index],
                0.80f + index * 0.06f)).ToArray();
        for (int i = 0; i < spines.Length; i++)
        {
            var s = spines[i];
            int h = (int)(maxH * s.Height);
            int lift = (i == hoverIndex) ? shelfLift : 0;
            var rect = new Rectangle(x, plankTop - h - lift, w, h);
            spineRects.Add(new Rectangle(x, plankTop - h - 10, w, h + 10));

            if (s.Copies == 0)
            {
                // Empty slot: a dashed outline where the book should be
                using var dash = new Pen(Red, 1.5f) { DashStyle = DashStyle.Dash };
                g.DrawRectangle(dash, x, plankTop - h, w, h - 1);
            }
            else
            {
                using var spineBrush = new SolidBrush(s.Color);
                g.FillRectangle(spineBrush, rect);
                using (var shade = new SolidBrush(Color.FromArgb(55, 0, 0, 0)))
                    g.FillRectangle(shade, rect.X, rect.Y, 6, rect.Height);

                g.DrawLine(bandPen, rect.X + 2, rect.Y + 12, rect.Right - 2, rect.Y + 12);
                g.DrawLine(bandPen, rect.X + 2, rect.Y + 16, rect.Right - 2, rect.Y + 16);
                g.DrawLine(bandPen, rect.X + 2, rect.Bottom - 16, rect.Right - 2, rect.Bottom - 16);
                g.DrawLine(bandPen, rect.X + 2, rect.Bottom - 12, rect.Right - 2, rect.Bottom - 12);

                // The title runs up the spine
                var state = g.Save();
                g.TranslateTransform(rect.X + w / 2f, rect.Y + h / 2f);
                g.RotateTransform(-90);
                using var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter,
                    FormatFlags = StringFormatFlags.NoWrap
                };
                g.DrawString(s.Title, titleFont, creamBrush,
                    new RectangleF(-(h - 44) / 2f, -w / 2f, h - 44, w), sf);
                g.Restore(state);
            }

            // The count label under the plank
            string num = s.Copies.ToString();
            string word = s.Copies == 0 ? "sold out" : "left";
            float cx = x + w / 2f;
            SizeF ns = g.MeasureString(num, tagNum);
            SizeF ws = g.MeasureString(word, tagTxt);
            g.DrawString(num, tagNum, s.Copies == 0 ? redBrush : inkBrush, cx - ns.Width / 2, plankTop + plankH + 4);
            g.DrawString(word, tagTxt, s.Copies == 0 ? redBrush : softBrush, cx - ws.Width / 2, plankTop + plankH + 26);

            x += w + gap;
        }

        // The wooden plank and a bookend
        using var woodBrush = new SolidBrush(Wood);
        g.FillRectangle(woodBrush, 12, plankTop, r.Width - 24, plankH);
        using var endBrush = new SolidBrush(Color.FromArgb(123, 90, 62));
        g.FillRectangle(endBrush, r.Width - 44, plankTop - 90, 14, 90);
    }

    private void ShelfMouseMove(object? sender, MouseEventArgs e)
    {
        int found = -1;
        for (int i = 0; i < spineRects.Count; i++)
        {
            if (spineRects[i].Contains(e.Location)) { found = i; break; }
        }
        SetHover(found);
    }

    private void SetHover(int index)
    {
        if (index == hoverIndex) return;
        hoverIndex = index;
        tmrShelfMotion.Start();
        pnlShelf.Cursor = index >= 0 ? Cursors.Hand : Cursors.Default;
        string text = "";
        if (index >= 0)
        {
            var book = DataStore.LowStockBooks().Skip(index).FirstOrDefault();
            if (book == null) return;
            var s = new Spine(book.Title, book.Quantity, Color.Empty, 1f);
            text = s.Copies == 0 ? s.Title + ": sold out" : s.Title + ": " + s.Copies + " left";
        }
        tip.SetToolTip(pnlShelf, text);
        pnlShelf.Invalidate();
    }

    private void tmrShelfMotion_Tick(object? sender, EventArgs e)
    {
        int targetLift = hoverIndex >= 0 ? 10 : 0;
        if (shelfLift < targetLift) shelfLift = Math.Min(targetLift, shelfLift + 2);
        else if (shelfLift > targetLift) shelfLift = Math.Max(targetLift, shelfLift - 2);
        else { tmrShelfMotion.Stop(); return; }
        pnlShelf.Invalidate();
    }

    // =====================================================================
    //  Today at the counter: a till receipt
    // =====================================================================
    private void PaintReceipt(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        var r = pnlReceipt.ClientRectangle;
        if (r.Width < 120 || r.Height < 100) return;

        g.Clear(Paper);
        using (var paperBrush = new SolidBrush(Color.FromArgb(251, 248, 240)))
            g.FillRectangle(paperBrush, 0, 0, r.Width - 1, r.Height - 1);
        using (var edge = new Pen(Rule))
            g.DrawRectangle(edge, 0, 0, r.Width - 1, r.Height - 1);

        // The torn, scalloped bottom edge
        using (var bg = new SolidBrush(Paper))
        {
            for (int sx = 4; sx < r.Width - 10; sx += 14)
                g.FillEllipse(bg, sx, r.Height - 7, 10, 10);
        }

        using var inkBrush = new SolidBrush(Ink);
        using var softBrush = new SolidBrush(Soft);
        using var head = new Font("Georgia", 14f, FontStyle.Bold);
        using var mono = new Font("Courier New", 10f);
        using var monoBold = new Font("Courier New", 10f, FontStyle.Bold);
        using var dash = new Pen(Rule, 1.4f) { DashStyle = DashStyle.Dash };
        using var dots = new Pen(Rule, 1.4f) { DashStyle = DashStyle.Dot };

        int left = 18, right = r.Width - 18, y = 16;
        g.DrawString("Today at the counter", head, inkBrush, left, y);
        y += 32;
        g.DrawString(DateTime.Now.ToString("dddd, d MMMM"), mono, softBrush, left, y);
        y += 24;
        g.DrawLine(dash, left, y, right, y);
        y += 10;

        int textLeft = left + 54;
        var entries = DataStore.TodayActivity().Take(3).Select(a => (Time: a.When.ToString("HH:mm"), Text: a.Text)).ToArray();
        foreach (var en in entries)
        {
            int width = right - textLeft;
            SizeF size = g.MeasureString(en.Text, mono, width);
            g.DrawString(en.Time, monoBold, inkBrush, left, y);
            g.DrawString(en.Text, mono, inkBrush, new RectangleF(textLeft, y, width, 60));
            y += (int)Math.Ceiling(size.Height) + 6;
            g.DrawLine(dots, left, y, right, y);
            y += 8;
        }

        g.DrawString(entries.Length + " entries so far", mono, softBrush, left, y + 2);
    }

    private void pnlLedger_Paint(object sender, PaintEventArgs e)
    {

    }
}
