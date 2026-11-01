using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace THE_READING_ROOM;

public partial class frmMain : Form
{
    public bool LoggedOut { get; private set; }

    private Button? activeButton;
    private readonly Dictionary<Button, Form> openPages = new();
    private readonly Dictionary<Button, (Image? Dark, Image? Light)> icons = new();

    private static readonly Color NavIdle = Color.FromArgb(221, 207, 180);
    private static readonly Color NavHover = Color.FromArgb(211, 193, 162);
    private static readonly Color Green = Color.FromArgb(61, 74, 59);
    private static readonly Color Cream = Color.FromArgb(244, 238, 225);
    private static readonly Color Ink = Color.FromArgb(58, 46, 36);

    public frmMain()
    {
        InitializeComponent();

        // Icons for the sidebar buttons: dark when idle, light when active
        // Use reflection to safely load resources that may not be embedded yet
        var rmgr = Properties.Resources.ResourceManager;
        try
        {
            icons[btnNavDashboard] = (GetResourceImage(rmgr, "ic_home_dark"), GetResourceImage(rmgr, "ic_home_light"));
            icons[btnNavBooks] = (GetResourceImage(rmgr, "ic_books_dark"), GetResourceImage(rmgr, "ic_books_light"));
            icons[btnNavCategories] = (GetResourceImage(rmgr, "ic_categories_dark"), GetResourceImage(rmgr, "ic_categories_light"));
            icons[btnNavSales] = (GetResourceImage(rmgr, "ic_sales_dark"), GetResourceImage(rmgr, "ic_sales_light"));
            icons[btnNavReports] = (GetResourceImage(rmgr, "ic_reports_dark"), GetResourceImage(rmgr, "ic_reports_light"));
            icons[btnNavSettings] = (GetResourceImage(rmgr, "ic_settings_dark"), GetResourceImage(rmgr, "ic_settings_light"));
            icons[btnLogout] = (GetResourceImage(rmgr, "ic_logout_dark"), GetResourceImage(rmgr, "ic_logout_light"));
            foreach (var pair in icons) if (pair.Value.Dark != null) pair.Key.Image = pair.Value.Dark;
            var logo = GetResourceImage(rmgr, "logo");
            if (logo != null) picLogo.Image = logo;
        }
        catch
        {
            // Resources not yet embedded; continue without them for now
        }

        // Connect the events here, so no designer clicks are needed
        foreach (var b in new[] { btnNavDashboard, btnNavBooks, btnNavCategories,
                                  btnNavSales, btnNavReports, btnNavSettings })
        {
            b.Click += NavButton_Click;
        }
        btnLogout.Click += btnLogout_Click;
        mnuLogout.Click += btnLogout_Click;
        mnuExit.Click += (s, e) => Close();
        mnuAbout.Click += (s, e) =>
            MessageBox.Show("The Reading Room\nBookstore management system, Phase 1.", "About");
        tmrClock.Tick += (s, e) => tslClock.Text = DateTime.Now.ToString("HH:mm");
        FormClosing += frmMain_FormClosing;
        PageUi.StatusRequested += PageUi_StatusRequested;
        DataStore.DataChanged += Main_DataChanged;
        Disposed += (_, _) =>
        {
            PageUi.StatusRequested -= PageUi_StatusRequested;
            DataStore.DataChanged -= Main_DataChanged;
        };

        // Who is signed in
        lblUserName.Text = Session.UserName;
        lblAvatar.Text = string.IsNullOrWhiteSpace(Session.UserName) ? "?" : Session.UserName.Trim()[0].ToString().ToUpperInvariant();
        lblRole.Text = Session.Role.ToUpper();
        lblStaffName.Text = Session.UserName;
        tslClock.Text = DateTime.Now.ToString("HH:mm");

        // Cashiers cannot see Reports or Settings
        if (Session.Role != "Admin")
        {
            btnNavReports.Visible = false;
            btnNavSettings.Visible = false;
        }

        ShowPage(btnNavDashboard);
    }

    private void PageUi_StatusRequested(string message)
    {
        if (IsDisposed) return;
        void UpdateStatus() => tslStatus.Text = "Status: " + message;
        if (InvokeRequired) BeginInvoke((Action)UpdateStatus); else UpdateStatus();
    }

    private void Main_DataChanged(object? sender, EventArgs e)
    {
        PageUi_StatusRequested("Data updated");
    }

    private void NavButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button b) ShowPage(b);
    }

    private void ShowPage(Button b)
    {
        if (activeButton != null) StyleNav(activeButton, false);
        activeButton = b;
        StyleNav(b, true);

        string title = b.Text.Trim();
        lblPageTitle.Text = title;
        lblTrail.Text = "Home  ›  " + title;
        tslStatus.Text = "Status: Ready";

        if (openPages.TryGetValue(b, out var existing) && !existing.IsDisposed)
        {
            if (existing.WindowState == FormWindowState.Minimized)
                existing.WindowState = FormWindowState.Normal;
            existing.BringToFront();
            existing.Activate();
            return;
        }

        Form? page = b == btnNavDashboard ? new frmDashboard()
            : b == btnNavBooks ? new frmBooks()
            : b == btnNavCategories ? new frmCategories()
            : b == btnNavSales ? new frmSales()
            : b == btnNavReports ? new frmReports()
            : b == btnNavSettings ? new frmSettings()
            : null;
        if (page == null) return;

        if (page is frmDashboard dashboard)
            dashboard.NavigateRequested += NavigateFromDashboard;

        openPages[b] = page;
        page.FormClosed += (_, _) =>
        {
            if (openPages.TryGetValue(b, out var openPage) && ReferenceEquals(openPage, page))
                openPages.Remove(b);
            if (activeButton == b)
            {
                StyleNav(b, false);
                activeButton = null;
            }
        };
        page.Show(this);
    }

    private void NavigateFromDashboard(string page)
    {
        Button? target = page switch
        {
            "Books" => btnNavBooks,
            "Categories" => btnNavCategories,
            "Sales" => btnNavSales,
            "Reports" => btnNavReports,
            _ => null
        };
        if (target != null && target.Visible) ShowPage(target);
    }

    private void StyleNav(Button b, bool active)
    {
        b.BackColor = active ? Green : NavIdle;
        b.ForeColor = active ? Cream : Ink;
        b.FlatAppearance.MouseOverBackColor = active ? Green : NavHover;
        if (icons.TryGetValue(b, out var ic))
            b.Image = active ? icons[b].Light : icons[b].Dark;
    }

    private void btnLogout_Click(object? sender, EventArgs e)
    {
        var answer = MessageBox.Show(
            "Log out of The Reading Room?\n\nA sale that isn't finished will be cleared.",
            "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

        if (answer == DialogResult.Yes)
        {
            LoggedOut = true;
            Session.Clear();
            Close();
        }
    }

    private void frmMain_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (LoggedOut) return;

        var answer = MessageBox.Show(
            "Close The Reading Room?\n\nEverything is stored in memory in this version, so closing the app clears your books and sales.",
            "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

        if (answer == DialogResult.No) e.Cancel = true;
    }

    private static Image? GetResourceImage(System.Resources.ResourceManager rmgr, string name)
    {
        try
        {
            return rmgr.GetObject(name) as Image;
        }
        catch
        {
            return null;
        }
    }

    private void lblSignedIn_Click(object sender, EventArgs e)
    {

    }

    private void lblUserName_Click(object sender, EventArgs e)
    {

    }

    private void lblUserName_Click_1(object sender, EventArgs e)
    {

    }
}

