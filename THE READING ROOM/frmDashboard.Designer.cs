namespace THE_READING_ROOM;

partial class frmDashboard
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tblRoot = new TableLayoutPanel();
        pnlBanner = new Panel();
        pnlCaption = new Panel();
        lblCapDate = new Label();
        lblCapTitle = new Label();
        pnlLedger = new Panel();
        pnlShelf = new Panel();
        lnkViewAll = new LinkLabel();
        pnlReceipt = new Panel();
        pnlActions = new Panel();
        lblActions = new Label();
        btnAddBook = new Button();
        btnRecordSale = new Button();
        btnOpenReports = new Button();
        tip = new ToolTip(components);
        tmrShelfMotion = new System.Windows.Forms.Timer(components);
        tmrShelfMotion.Interval = 18;
        tblRoot.SuspendLayout();
        pnlBanner.SuspendLayout();
        pnlCaption.SuspendLayout();
        pnlShelf.SuspendLayout();
        pnlActions.SuspendLayout();
        SuspendLayout();
        // 
        // tblRoot
        // 
        tblRoot.ColumnCount = 3;
        tblRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.6F));
        tblRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4F));
        tblRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 236F));
        tblRoot.Controls.Add(pnlBanner, 0, 0);
        tblRoot.Controls.Add(pnlLedger, 0, 1);
        tblRoot.Controls.Add(pnlShelf, 0, 2);
        tblRoot.Controls.Add(pnlReceipt, 1, 2);
        tblRoot.Controls.Add(pnlActions, 2, 2);
        tblRoot.Dock = DockStyle.Fill;
        tblRoot.Location = new Point(0, 0);
        tblRoot.Name = "tblRoot";
        tblRoot.RowCount = 3;
        tblRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 192F));
        tblRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
        tblRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblRoot.Size = new Size(1000, 640);
        tblRoot.TabIndex = 0;
        // 
        // pnlBanner
        // 
        pnlBanner.BackColor = Color.FromArgb(59, 45, 34);
        pnlBanner.BackgroundImageLayout = ImageLayout.Center;
        tblRoot.SetColumnSpan(pnlBanner, 3);
        pnlBanner.Controls.Add(pnlCaption);
        pnlBanner.Dock = DockStyle.Fill;
        pnlBanner.Location = new Point(0, 0);
        pnlBanner.Margin = new Padding(0, 0, 0, 16);
        pnlBanner.Name = "pnlBanner";
        pnlBanner.Size = new Size(1000, 176);
        pnlBanner.TabIndex = 0;
        // 
        // pnlCaption
        // 
        pnlCaption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        pnlCaption.BackColor = Color.FromArgb(244, 238, 225);
        pnlCaption.Controls.Add(lblCapDate);
        pnlCaption.Controls.Add(lblCapTitle);
        pnlCaption.Location = new Point(20, 80);
        pnlCaption.Name = "pnlCaption";
        pnlCaption.Size = new Size(410, 78);
        pnlCaption.TabIndex = 0;
        // 
        // lblCapDate
        // 
        lblCapDate.AutoSize = true;
        lblCapDate.Font = new Font("Segoe UI", 9.5F);
        lblCapDate.ForeColor = Color.FromArgb(107, 91, 75);
        lblCapDate.Location = new Point(22, 10);
        lblCapDate.Name = "lblCapDate";
        lblCapDate.Size = new Size(129, 17);
        lblCapDate.TabIndex = 0;
        lblCapDate.Text = "Tuesday, 27 October";
        // 
        // lblCapTitle
        // 
        lblCapTitle.AutoSize = true;
        lblCapTitle.Font = new Font("Georgia", 17F, FontStyle.Bold);
        lblCapTitle.ForeColor = Color.FromArgb(58, 46, 36);
        lblCapTitle.Location = new Point(20, 30);
        lblCapTitle.Name = "lblCapTitle";
        lblCapTitle.Size = new Size(368, 27);
        lblCapTitle.TabIndex = 1;
        lblCapTitle.Text = "A little order for your shelves.";
        // 
        // pnlLedger
        // 
        pnlLedger.BackColor = Color.FromArgb(244, 238, 225);
        tblRoot.SetColumnSpan(pnlLedger, 3);
        pnlLedger.Dock = DockStyle.Fill;
        pnlLedger.Location = new Point(0, 192);
        pnlLedger.Margin = new Padding(0, 0, 0, 16);
        pnlLedger.Name = "pnlLedger";
        pnlLedger.Size = new Size(1000, 124);
        pnlLedger.TabIndex = 1;
        pnlLedger.Paint += pnlLedger_Paint;
        // 
        // pnlShelf
        // 
        pnlShelf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlShelf.BackColor = Color.FromArgb(239, 230, 211);
        pnlShelf.Controls.Add(lnkViewAll);
        pnlShelf.Location = new Point(0, 332);
        pnlShelf.Margin = new Padding(0, 0, 16, 0);
        pnlShelf.Name = "pnlShelf";
        pnlShelf.Size = new Size(408, 300);
        pnlShelf.TabIndex = 2;
        // 
        // lnkViewAll
        // 
        lnkViewAll.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lnkViewAll.AutoSize = true;
        lnkViewAll.Font = new Font("Segoe UI", 9.5F);
        lnkViewAll.LinkColor = Color.FromArgb(138, 90, 18);
        lnkViewAll.Location = new Point(325, 18);
        lnkViewAll.Name = "lnkViewAll";
        lnkViewAll.Size = new Size(63, 17);
        lnkViewAll.TabIndex = 0;
        lnkViewAll.TabStop = true;
        lnkViewAll.Text = "View all 8";

        // pnlReceipt
        // 
        pnlReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlReceipt.BackColor = Color.FromArgb(234, 225, 209);
        pnlReceipt.Location = new Point(424, 332);
        pnlReceipt.Margin = new Padding(0, 0, 16, 0);
        pnlReceipt.Name = "pnlReceipt";
        pnlReceipt.Size = new Size(323, 260);
        pnlReceipt.TabIndex = 3;
        // 
        // pnlActions
        // 
        pnlActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlActions.BackColor = Color.FromArgb(234, 225, 209);
        pnlActions.Controls.Add(lblActions);
        pnlActions.Controls.Add(btnAddBook);
        pnlActions.Controls.Add(btnRecordSale);
        pnlActions.Controls.Add(btnOpenReports);
        pnlActions.Location = new Point(763, 332);
        pnlActions.Margin = new Padding(0);
        pnlActions.Name = "pnlActions";
        pnlActions.Size = new Size(237, 260);
        pnlActions.TabIndex = 4;
        // 
        // lblActions
        // 
        lblActions.AutoSize = true;
        lblActions.Font = new Font("Georgia", 14F, FontStyle.Bold);
        lblActions.ForeColor = Color.FromArgb(58, 46, 36);
        lblActions.Location = new Point(0, 8);
        lblActions.Name = "lblActions";
        lblActions.Size = new Size(144, 23);
        lblActions.TabIndex = 0;
        lblActions.Text = "Quick actions";
        // 
        // btnAddBook
        // 
        btnAddBook.BackColor = Color.FromArgb(61, 74, 59);
        btnAddBook.Cursor = Cursors.Hand;
        btnAddBook.FlatAppearance.BorderSize = 0;
        btnAddBook.FlatStyle = FlatStyle.Flat;
        btnAddBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnAddBook.ForeColor = Color.FromArgb(244, 238, 225);
        btnAddBook.Location = new Point(0, 52);
        btnAddBook.Name = "btnAddBook";
        btnAddBook.Padding = new Padding(16, 0, 0, 0);
        btnAddBook.Size = new Size(220, 54);
        btnAddBook.TabIndex = 1;
        btnAddBook.Text = "Add a book";
        btnAddBook.TextAlign = ContentAlignment.MiddleLeft;
        btnAddBook.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnAddBook.UseVisualStyleBackColor = false;
        // 
        // btnRecordSale
        // 
        btnRecordSale.BackColor = Color.FromArgb(126, 95, 69);
        btnRecordSale.Cursor = Cursors.Hand;
        btnRecordSale.FlatAppearance.BorderSize = 0;
        btnRecordSale.FlatStyle = FlatStyle.Flat;
        btnRecordSale.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnRecordSale.ForeColor = Color.FromArgb(255, 255, 255);
        btnRecordSale.Location = new Point(0, 118);
        btnRecordSale.Name = "btnRecordSale";
        btnRecordSale.Padding = new Padding(16, 0, 0, 0);
        btnRecordSale.Size = new Size(220, 54);
        btnRecordSale.TabIndex = 2;
        btnRecordSale.Text = "Record a sale";
        btnRecordSale.TextAlign = ContentAlignment.MiddleLeft;
        btnRecordSale.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnRecordSale.UseVisualStyleBackColor = false;
        // 
        // btnOpenReports
        // 
        btnOpenReports.BackColor = Color.FromArgb(244, 238, 225);
        btnOpenReports.Cursor = Cursors.Hand;
        btnOpenReports.FlatAppearance.BorderColor = Color.FromArgb(201, 181, 142);
        btnOpenReports.FlatStyle = FlatStyle.Flat;
        btnOpenReports.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnOpenReports.ForeColor = Color.FromArgb(58, 46, 36);
        btnOpenReports.Location = new Point(0, 184);
        btnOpenReports.Name = "btnOpenReports";
        btnOpenReports.Padding = new Padding(16, 0, 0, 0);
        btnOpenReports.Size = new Size(220, 54);
        btnOpenReports.TabIndex = 3;
        btnOpenReports.Text = "Open reports";
        btnOpenReports.TextAlign = ContentAlignment.MiddleLeft;
        btnOpenReports.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnOpenReports.UseVisualStyleBackColor = false;
        // 
        // frmDashboard
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(234, 225, 209);
        Controls.Add(tblRoot);
        ClientSize = new Size(1000, 640);
        MinimumSize = new Size(900, 600);
        Name = "frmDashboard";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Dashboard";
        tblRoot.ResumeLayout(false);
        pnlBanner.ResumeLayout(false);
        pnlCaption.ResumeLayout(false);
        pnlCaption.PerformLayout();
        pnlShelf.ResumeLayout(false);
        pnlShelf.PerformLayout();
        pnlActions.ResumeLayout(false);
        pnlActions.PerformLayout();
        ResumeLayout(false);
    }

    private TableLayoutPanel tblRoot;
    private Panel pnlBanner;
    private Panel pnlCaption;
    private Label lblCapDate;
    private Label lblCapTitle;
    private Panel pnlLedger;
    private Panel pnlShelf;
    private LinkLabel lnkViewAll;
    private Panel pnlReceipt;
    private Panel pnlActions;
    private Label lblActions;
    private Button btnAddBook;
    private Button btnRecordSale;
    private Button btnOpenReports;
    private ToolTip tip;
    private System.Windows.Forms.Timer tmrShelfMotion;
}
