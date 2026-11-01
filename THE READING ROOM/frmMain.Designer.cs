namespace THE_READING_ROOM;

partial class frmMain
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
        components = new System.ComponentModel.Container();
        mnuMain = new MenuStrip();
        mnuFile = new ToolStripMenuItem();
        mnuLogout = new ToolStripMenuItem();
        mnuExit = new ToolStripMenuItem();
        mnuEdit = new ToolStripMenuItem();
        mnuView = new ToolStripMenuItem();
        mnuTools = new ToolStripMenuItem();
        mnuHelp = new ToolStripMenuItem();
        mnuAbout = new ToolStripMenuItem();
        pnlSidebar = new Panel();
        picLogo = new PictureBox();
        picShelfPhoto = new PictureBox();
        lblBrand = new Label();
        btnNavDashboard = new Button();
        btnNavBooks = new Button();
        btnNavCategories = new Button();
        btnNavSales = new Button();
        btnNavReports = new Button();
        btnNavSettings = new Button();
        pnlSideBottom = new Panel();
        btnLogout = new Button();
        lblStaffKey = new Label();
        lblStaffName = new Label();
        lblModeKey = new Label();
        lblModeVal = new Label();
        pnlHeader = new Panel();
        pnlUser = new Panel();
        lblSignedIn = new Label();
        lblAvatar = new Label();
        lblUserName = new Label();
        lblRole = new Label();
        lblPageTitle = new Label();
        lblTrail = new Label();
        stsMain = new StatusStrip();
        tslDot = new ToolStripStatusLabel();
        tslStatus = new ToolStripStatusLabel();
        tslTitles = new ToolStripStatusLabel();
        tslStorage = new ToolStripStatusLabel();
        tslSpacer = new ToolStripStatusLabel();
        tslClock = new ToolStripStatusLabel();
        pnlContent = new Panel();
        lblOpenHint = new Label();
        tmrClock = new System.Windows.Forms.Timer(components);
        mnuMain.SuspendLayout();
        pnlSidebar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picShelfPhoto).BeginInit();
        pnlSideBottom.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlUser.SuspendLayout();
        stsMain.SuspendLayout();
        SuspendLayout();
        // 
        // mnuMain
        // 
        mnuMain.BackColor = Color.FromArgb(244, 238, 225);
        mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit, mnuView, mnuTools, mnuHelp });
        mnuMain.Location = new Point(0, 0);
        mnuMain.Name = "mnuMain";
        mnuMain.RenderMode = ToolStripRenderMode.System;
        mnuMain.Size = new Size(1200, 24);
        mnuMain.TabIndex = 0;
        mnuMain.Text = "menuStrip1";
        // 
        // mnuFile
        // 
        mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, mnuExit });
        mnuFile.Name = "mnuFile";
        mnuFile.Size = new Size(37, 20);
        mnuFile.Text = "File";
        // 
        // mnuLogout
        // 
        mnuLogout.Name = "mnuLogout";
        mnuLogout.ShortcutKeys = Keys.Control | Keys.L;
        mnuLogout.Size = new Size(155, 22);
        mnuLogout.Text = "Log out";
        // 
        // mnuExit
        // 
        mnuExit.Name = "mnuExit";
        mnuExit.ShortcutKeys = Keys.Alt | Keys.F4;
        mnuExit.Size = new Size(155, 22);
        mnuExit.Text = "Exit";
        // 
        // mnuEdit
        // 
        mnuEdit.Name = "mnuEdit";
        mnuEdit.Size = new Size(39, 20);
        mnuEdit.Text = "Edit";
        // 
        // mnuView
        // 
        mnuView.Name = "mnuView";
        mnuView.Size = new Size(44, 20);
        mnuView.Text = "View";
        // 
        // mnuTools
        // 
        mnuTools.Name = "mnuTools";
        mnuTools.Size = new Size(47, 20);
        mnuTools.Text = "Tools";
        // 
        // mnuHelp
        // 
        mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
        mnuHelp.Name = "mnuHelp";
        mnuHelp.Size = new Size(44, 20);
        mnuHelp.Text = "Help";
        // 
        // mnuAbout
        // 
        mnuAbout.Name = "mnuAbout";
        mnuAbout.Size = new Size(107, 22);
        mnuAbout.Text = "About";
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(221, 207, 180);
        pnlSidebar.Controls.Add(picLogo);
        pnlSidebar.Controls.Add(lblBrand);
        pnlSidebar.Controls.Add(btnNavDashboard);
        pnlSidebar.Controls.Add(btnNavBooks);
        pnlSidebar.Controls.Add(btnNavCategories);
        pnlSidebar.Controls.Add(btnNavSales);
        pnlSidebar.Controls.Add(btnNavReports);
        pnlSidebar.Controls.Add(btnNavSettings);
        pnlSidebar.Controls.Add(picShelfPhoto);
        pnlSidebar.Controls.Add(pnlSideBottom);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 24);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(248, 716);
        pnlSidebar.TabIndex = 1;
        // 
        // picLogo
        // 
        picLogo.Location = new Point(101, 18);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(46, 46);
        picLogo.SizeMode = PictureBoxSizeMode.Zoom;
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        // 
        // picShelfPhoto
        // 
        picShelfPhoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        picShelfPhoto.BackColor = Color.FromArgb(244, 238, 225);
        picShelfPhoto.BorderStyle = BorderStyle.FixedSingle;
        picShelfPhoto.Image = (Image)resources.GetObject("picShelfPhoto.Image");
        picShelfPhoto.Location = new Point(16, 430);
        picShelfPhoto.Name = "picShelfPhoto";
        picShelfPhoto.Size = new Size(216, 120);
        picShelfPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        picShelfPhoto.TabIndex = 9;
        picShelfPhoto.TabStop = false;
        // 
        // lblBrand
        // 
        lblBrand.Font = new Font("Georgia", 16F, FontStyle.Bold);
        lblBrand.Location = new Point(0, 68);
        lblBrand.Name = "lblBrand";
        lblBrand.Size = new Size(248, 30);
        lblBrand.TabIndex = 1;
        lblBrand.Text = "The Reading Room";
        lblBrand.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnNavDashboard
        // 
        btnNavDashboard.BackColor = Color.FromArgb(61, 74, 59);
        btnNavDashboard.FlatAppearance.BorderSize = 0;
        btnNavDashboard.FlatStyle = FlatStyle.Flat;
        btnNavDashboard.Font = new Font("Segoe UI", 11F);
        btnNavDashboard.ForeColor = Color.FromArgb(244, 238, 225);
        btnNavDashboard.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavDashboard.Location = new Point(16, 136);
        btnNavDashboard.Name = "btnNavDashboard";
        btnNavDashboard.Padding = new Padding(14, 0, 0, 0);
        btnNavDashboard.Size = new Size(216, 44);
        btnNavDashboard.TabIndex = 2;
        btnNavDashboard.Text = "Dashboard";
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnNavDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavDashboard.UseVisualStyleBackColor = false;
        // 
        // btnNavBooks
        // 
        btnNavBooks.BackColor = Color.FromArgb(221, 207, 180);
        btnNavBooks.FlatAppearance.BorderSize = 0;
        btnNavBooks.FlatStyle = FlatStyle.Flat;
        btnNavBooks.Font = new Font("Segoe UI", 11F);
        btnNavBooks.ForeColor = Color.FromArgb(58, 46, 36);
        btnNavBooks.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavBooks.Location = new Point(16, 184);
        btnNavBooks.Name = "btnNavBooks";
        btnNavBooks.Padding = new Padding(14, 0, 0, 0);
        btnNavBooks.Size = new Size(216, 44);
        btnNavBooks.TabIndex = 3;
        btnNavBooks.Text = "Books";
        btnNavBooks.TextAlign = ContentAlignment.MiddleLeft;
        btnNavBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavBooks.UseVisualStyleBackColor = false;
        // 
        // btnNavCategories
        // 
        btnNavCategories.BackColor = Color.FromArgb(221, 207, 180);
        btnNavCategories.FlatAppearance.BorderSize = 0;
        btnNavCategories.FlatStyle = FlatStyle.Flat;
        btnNavCategories.Font = new Font("Segoe UI", 11F);
        btnNavCategories.ForeColor = Color.FromArgb(58, 46, 36);
        btnNavCategories.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavCategories.Location = new Point(16, 232);
        btnNavCategories.Name = "btnNavCategories";
        btnNavCategories.Padding = new Padding(14, 0, 0, 0);
        btnNavCategories.Size = new Size(216, 44);
        btnNavCategories.TabIndex = 4;
        btnNavCategories.Text = "Categories";
        btnNavCategories.TextAlign = ContentAlignment.MiddleLeft;
        btnNavCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavCategories.UseMnemonic = false;
        btnNavCategories.UseVisualStyleBackColor = false;
        // 
        // btnNavSales
        // 
        btnNavSales.BackColor = Color.FromArgb(221, 207, 180);
        btnNavSales.FlatAppearance.BorderSize = 0;
        btnNavSales.FlatStyle = FlatStyle.Flat;
        btnNavSales.Font = new Font("Segoe UI", 11F);
        btnNavSales.ForeColor = Color.FromArgb(58, 46, 36);
        btnNavSales.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavSales.Location = new Point(16, 280);
        btnNavSales.Name = "btnNavSales";
        btnNavSales.Padding = new Padding(14, 0, 0, 0);
        btnNavSales.Size = new Size(216, 44);
        btnNavSales.TabIndex = 5;
        btnNavSales.Text = "Sales & Checkout";
        btnNavSales.TextAlign = ContentAlignment.MiddleLeft;
        btnNavSales.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavSales.UseMnemonic = false;
        btnNavSales.UseVisualStyleBackColor = false;
        // 
        // btnNavReports
        // 
        btnNavReports.BackColor = Color.FromArgb(221, 207, 180);
        btnNavReports.FlatAppearance.BorderSize = 0;
        btnNavReports.FlatStyle = FlatStyle.Flat;
        btnNavReports.Font = new Font("Segoe UI", 11F);
        btnNavReports.ForeColor = Color.FromArgb(58, 46, 36);
        btnNavReports.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavReports.Location = new Point(16, 328);
        btnNavReports.Name = "btnNavReports";
        btnNavReports.Padding = new Padding(14, 0, 0, 0);
        btnNavReports.Size = new Size(216, 44);
        btnNavReports.TabIndex = 6;
        btnNavReports.Text = "Reports";
        btnNavReports.TextAlign = ContentAlignment.MiddleLeft;
        btnNavReports.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavReports.UseMnemonic = false;
        btnNavReports.UseVisualStyleBackColor = false;
        // 
        // btnNavSettings
        // 
        btnNavSettings.BackColor = Color.FromArgb(221, 207, 180);
        btnNavSettings.FlatAppearance.BorderSize = 0;
        btnNavSettings.FlatStyle = FlatStyle.Flat;
        btnNavSettings.Font = new Font("Segoe UI", 11F);
        btnNavSettings.ForeColor = Color.FromArgb(58, 46, 36);
        btnNavSettings.ImageAlign = ContentAlignment.MiddleLeft;
        btnNavSettings.Location = new Point(16, 376);
        btnNavSettings.Name = "btnNavSettings";
        btnNavSettings.Padding = new Padding(14, 0, 0, 0);
        btnNavSettings.Size = new Size(216, 44);
        btnNavSettings.TabIndex = 7;
        btnNavSettings.Text = "Settings";
        btnNavSettings.TextAlign = ContentAlignment.MiddleLeft;
        btnNavSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnNavSettings.UseMnemonic = false;
        btnNavSettings.UseVisualStyleBackColor = false;
        // 
        // pnlSideBottom
        // 
        pnlSideBottom.BackColor = Color.FromArgb(221, 207, 180);
        pnlSideBottom.Controls.Add(btnLogout);
        pnlSideBottom.Controls.Add(lblStaffKey);
        pnlSideBottom.Controls.Add(lblStaffName);
        pnlSideBottom.Controls.Add(lblModeKey);
        pnlSideBottom.Controls.Add(lblModeVal);
        pnlSideBottom.Dock = DockStyle.Bottom;
        pnlSideBottom.Location = new Point(0, 565);
        pnlSideBottom.Name = "pnlSideBottom";
        pnlSideBottom.Size = new Size(248, 151);
        pnlSideBottom.TabIndex = 8;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = Color.FromArgb(221, 207, 180);
        btnLogout.FlatAppearance.BorderSize = 0;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.Font = new Font("Segoe UI", 11F);
        btnLogout.ForeColor = Color.FromArgb(58, 46, 36);
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
        btnLogout.Location = new Point(12, 83);
        btnLogout.Name = "btnLogout";
        btnLogout.Padding = new Padding(14, 0, 0, 0);
        btnLogout.Size = new Size(216, 44);
        btnLogout.TabIndex = 3;
        btnLogout.Text = "Log out";
        btnLogout.TextAlign = ContentAlignment.MiddleLeft;
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnLogout.UseVisualStyleBackColor = false;
        // 
        // lblStaffKey
        // 
        lblStaffKey.AutoSize = true;
        lblStaffKey.Font = new Font("Segoe UI", 8.25F);
        lblStaffKey.ForeColor = Color.FromArgb(107, 91, 75);
        lblStaffKey.Location = new Point(16, 8);
        lblStaffKey.Name = "lblStaffKey";
        lblStaffKey.Size = new Size(31, 13);
        lblStaffKey.TabIndex = 0;
        lblStaffKey.Text = "Staff";
        // 
        // lblStaffName
        // 
        lblStaffName.AutoSize = true;
        lblStaffName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblStaffName.ForeColor = Color.FromArgb(58, 46, 36);
        lblStaffName.Location = new Point(16, 24);
        lblStaffName.Name = "lblStaffName";
        lblStaffName.Size = new Size(43, 17);
        lblStaffName.TabIndex = 1;
        lblStaffName.Text = "Melat";
        // 
        // lblModeKey
        // 
        lblModeKey.AutoSize = true;
        lblModeKey.Font = new Font("Segoe UI", 8.25F);
        lblModeKey.ForeColor = Color.FromArgb(107, 91, 75);
        lblModeKey.Location = new Point(16, 44);
        lblModeKey.Name = "lblModeKey";
        lblModeKey.Size = new Size(37, 13);
        lblModeKey.TabIndex = 2;
        lblModeKey.Text = "Mode";
        // 
        // lblModeVal
        // 
        lblModeVal.AutoSize = true;
        lblModeVal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblModeVal.ForeColor = Color.FromArgb(58, 46, 36);
        lblModeVal.Location = new Point(16, 60);
        lblModeVal.Name = "lblModeVal";
        lblModeVal.Size = new Size(96, 17);
        lblModeVal.TabIndex = 3;
        lblModeVal.Text = "Local memory";
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(244, 238, 225);
        pnlHeader.Controls.Add(pnlUser);
        pnlHeader.Controls.Add(lblPageTitle);
        pnlHeader.Controls.Add(lblTrail);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(248, 24);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(952, 58);
        pnlHeader.TabIndex = 2;
        // 
        // pnlUser
        // 
        pnlUser.BackColor = Color.FromArgb(244, 238, 225);
        pnlUser.Controls.Add(lblRole);
        pnlUser.Controls.Add(lblSignedIn);
        pnlUser.Controls.Add(lblAvatar);
        pnlUser.Controls.Add(lblUserName);
        pnlUser.Dock = DockStyle.Right;
        pnlUser.Location = new Point(622, 0);
        pnlUser.Name = "pnlUser";
        pnlUser.Size = new Size(330, 58);
        pnlUser.TabIndex = 2;
        // 
        // lblSignedIn
        // 
        lblSignedIn.AutoSize = true;
        lblSignedIn.Font = new Font("Segoe UI", 9F);
        lblSignedIn.ForeColor = Color.FromArgb(107, 91, 75);
        lblSignedIn.Location = new Point(119, 19);
        lblSignedIn.Name = "lblSignedIn";
        lblSignedIn.Size = new Size(70, 15);
        lblSignedIn.TabIndex = 2;
        lblSignedIn.Text = "Signed in as";
        // 
        // lblAvatar
        // 
        lblAvatar.BackColor = Color.FromArgb(61, 74, 59);
        lblAvatar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblAvatar.ForeColor = Color.FromArgb(244, 238, 225);
        lblAvatar.Location = new Point(206, 13);
        lblAvatar.Name = "lblAvatar";
        lblAvatar.Size = new Size(28, 28);
        lblAvatar.TabIndex = 3;
        lblAvatar.Text = "A";
        lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblUserName
        // 
        lblUserName.AutoSize = true;
        lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblUserName.ForeColor = Color.FromArgb(58, 46, 36);
        lblUserName.Location = new Point(260, 24);
        lblUserName.Name = "lblUserName";
        lblUserName.Size = new Size(41, 15);
        lblUserName.TabIndex = 5;
        lblUserName.Text = "admin";
        lblUserName.Click += lblUserName_Click_1;
        // 
        // lblRole
        // 
        lblRole.BorderStyle = BorderStyle.FixedSingle;
        lblRole.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblRole.ForeColor = Color.FromArgb(61, 74, 59);
        lblRole.Location = new Point(250, 17);
        lblRole.Name = "lblRole";
        lblRole.Size = new Size(70, 22);
        lblRole.TabIndex = 6;
        lblRole.Text = "ADMIN";
        lblRole.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblPageTitle
        // 
        lblPageTitle.AutoSize = true;
        lblPageTitle.Font = new Font("Georgia", 18F, FontStyle.Bold);
        lblPageTitle.ForeColor = Color.FromArgb(58, 46, 36);
        lblPageTitle.Location = new Point(24, 8);
        lblPageTitle.Name = "lblPageTitle";
        lblPageTitle.Size = new Size(148, 29);
        lblPageTitle.TabIndex = 0;
        lblPageTitle.Text = "Dashboard";
        // 
        // lblTrail
        // 
        lblTrail.AutoSize = true;
        lblTrail.Font = new Font("Segoe UI", 9.5F);
        lblTrail.ForeColor = Color.FromArgb(107, 91, 75);
        lblTrail.Location = new Point(24, 36);
        lblTrail.Name = "lblTrail";
        lblTrail.Size = new Size(128, 17);
        lblTrail.TabIndex = 1;
        lblTrail.Text = "Home  ›  Dashboard";
        // 
        // stsMain
        // 
        stsMain.BackColor = Color.FromArgb(244, 238, 225);
        stsMain.Items.AddRange(new ToolStripItem[] { tslDot, tslStatus, tslTitles, tslStorage, tslSpacer, tslClock });
        stsMain.Location = new Point(248, 716);
        stsMain.Name = "stsMain";
        stsMain.Size = new Size(952, 24);
        stsMain.TabIndex = 3;
        // 
        // tslDot
        // 
        tslDot.BackColor = Color.FromArgb(244, 238, 225);
        tslDot.ForeColor = Color.FromArgb(61, 74, 59);
        tslDot.Name = "tslDot";
        tslDot.Size = new Size(14, 19);
        tslDot.Text = "●";
        // 
        // tslStatus
        // 
        tslStatus.BackColor = Color.FromArgb(244, 238, 225);
        tslStatus.ForeColor = Color.FromArgb(58, 46, 36);
        tslStatus.Name = "tslStatus";
        tslStatus.Size = new Size(77, 19);
        tslStatus.Text = "Status: Ready";
        // 
        // tslTitles
        // 
        tslTitles.BackColor = Color.FromArgb(244, 238, 225);
        tslTitles.ForeColor = Color.FromArgb(58, 46, 36);
        tslTitles.Name = "tslTitles";
        tslTitles.Size = new Size(135, 19);
        tslTitles.Text = "1,240 titles in the system";
        // 
        // tslStorage
        // 
        tslStorage.BackColor = Color.FromArgb(244, 238, 225);
        tslStorage.ForeColor = Color.FromArgb(58, 46, 36);
        tslStorage.Name = "tslStorage";
        tslStorage.Size = new Size(122, 19);
        tslStorage.Text = "Local memory loaded";
        // 
        // tslSpacer
        // 
        tslSpacer.AutoSize = false;
        tslSpacer.BackColor = Color.FromArgb(244, 238, 225);
        tslSpacer.Name = "tslSpacer";
        tslSpacer.Size = new Size(555, 19);
        tslSpacer.Spring = true;
        // 
        // tslClock
        // 
        tslClock.BackColor = Color.FromArgb(244, 238, 225);
        tslClock.ForeColor = Color.FromArgb(58, 46, 36);
        tslClock.Name = "tslClock";
        tslClock.Size = new Size(34, 19);
        tslClock.Text = "12:34";
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(234, 225, 209);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(248, 82);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new Padding(24);
        pnlContent.Size = new Size(952, 634);
        pnlContent.TabIndex = 4;
        lblOpenHint.Dock = DockStyle.Fill;
        lblOpenHint.Font = new Font("Georgia", 18F, FontStyle.Bold);
        lblOpenHint.ForeColor = Color.FromArgb(107, 91, 75);
        lblOpenHint.Text = "Choose a section from the sidebar. Each section opens in its own window.";
        lblOpenHint.TextAlign = ContentAlignment.MiddleCenter;
        pnlContent.Controls.Add(lblOpenHint);
        // 
        // tmrClock
        // 
        tmrClock.Enabled = true;
        tmrClock.Interval = 1000;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1200, 740);
        MinimumSize = new Size(1100, 700);
        Controls.Add(pnlContent);
        Controls.Add(stsMain);
        Controls.Add(pnlHeader);
        Controls.Add(pnlSidebar);
        Controls.Add(mnuMain);
        MainMenuStrip = mnuMain;
        Name = "frmMain";
        Text = "The Reading Room: Bookstore Management";
        WindowState = FormWindowState.Maximized;
        mnuMain.ResumeLayout(false);
        mnuMain.PerformLayout();
        pnlSidebar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ((System.ComponentModel.ISupportInitialize)picShelfPhoto).EndInit();
        pnlSideBottom.ResumeLayout(false);
        pnlSideBottom.PerformLayout();
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlUser.ResumeLayout(false);
        pnlUser.PerformLayout();
        stsMain.ResumeLayout(false);
        stsMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private MenuStrip mnuMain;
    private ToolStripMenuItem mnuFile;
    private ToolStripMenuItem mnuLogout;
    private ToolStripMenuItem mnuExit;
    private ToolStripMenuItem mnuEdit;
    private ToolStripMenuItem mnuView;
    private ToolStripMenuItem mnuTools;
    private ToolStripMenuItem mnuHelp;
    private ToolStripMenuItem mnuAbout;

    private Panel pnlSidebar;
    private PictureBox picLogo;
    private PictureBox picShelfPhoto;
    private Label lblBrand;
    private Button btnNavDashboard;
    private Button btnNavBooks;
    private Button btnNavCategories;
    private Button btnNavSales;
    private Button btnNavReports;
    private Button btnNavSettings;
    private Panel pnlSideBottom;
    private Button btnLogout;
    private Label lblStaffKey;
    private Label lblStaffName;
    private Label lblModeKey;
    private Label lblModeVal;

    private Panel pnlHeader;
    private Panel pnlUser;
    private Label lblPageTitle;
    private Label lblTrail;
    private Label lblSignedIn;
    private Label lblAvatar;

    private StatusStrip stsMain;
    private ToolStripStatusLabel tslDot;
    private ToolStripStatusLabel tslStatus;
    private ToolStripStatusLabel tslTitles;
    private ToolStripStatusLabel tslStorage;
    private ToolStripStatusLabel tslSpacer;
    private ToolStripStatusLabel tslClock;

    private Panel pnlContent;
    private Label lblOpenHint;
    private System.Windows.Forms.Timer tmrClock;
    private Label lblUserName;
    private Label lblRole;
}
