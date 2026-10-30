namespace THE_READING_ROOM
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stsMain = new StatusStrip();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnNavSettings = new Button();
            btnNavReports = new Button();
            btnNavSales = new Button();
            btnNavCategories = new Button();
            btnNavBooks = new Button();
            btnNavDashboard = new Button();
            lblBrandSub = new Label();
            lblBrand = new Label();
            pnlHeader = new Panel();
            lblSignedIn = new Label();
            lblTrail = new Label();
            lblPageTitle = new Label();
            pnlContent = new Panel();
            lblAvatar = new Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // stsMain
            // 
            stsMain.BackColor = Color.FromArgb(220, 203, 176);
            stsMain.Location = new Point(220, 659);
            stsMain.Name = "stsMain";
            stsMain.Size = new Size(764, 22);
            stsMain.TabIndex = 0;
            stsMain.Text = "statusStrip1";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(216, 195, 165);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnNavSettings);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnNavSales);
            pnlSidebar.Controls.Add(btnNavCategories);
            pnlSidebar.Controls.Add(btnNavBooks);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(lblBrandSub);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 681);
            pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 160, 125);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 176, 140);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(75, 56, 42);
            btnLogout.Location = new Point(12, 630);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(14, 0, 0, 0);
            btnLogout.Size = new Size(196, 42);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseMnemonic = false;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnNavSettings
            // 
            btnNavSettings.Cursor = Cursors.Hand;
            btnNavSettings.FlatAppearance.BorderSize = 0;
            btnNavSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 160, 125);
            btnNavSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 176, 140);
            btnNavSettings.FlatStyle = FlatStyle.Flat;
            btnNavSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavSettings.ForeColor = Color.FromArgb(75, 56, 42);
            btnNavSettings.Location = new Point(12, 320);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Padding = new Padding(14, 0, 0, 0);
            btnNavSettings.Size = new Size(196, 42);
            btnNavSettings.TabIndex = 6;
            btnNavSettings.Text = "Settings";
            btnNavSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSettings.UseMnemonic = false;
            btnNavSettings.UseVisualStyleBackColor = true;
            // 
            // btnNavReports
            // 
            btnNavReports.Cursor = Cursors.Hand;
            btnNavReports.FlatAppearance.BorderSize = 0;
            btnNavReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 160, 125);
            btnNavReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 176, 140);
            btnNavReports.FlatStyle = FlatStyle.Flat;
            btnNavReports.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavReports.ForeColor = Color.FromArgb(75, 56, 42);
            btnNavReports.Location = new Point(12, 274);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Padding = new Padding(14, 0, 0, 0);
            btnNavReports.Size = new Size(196, 42);
            btnNavReports.TabIndex = 5;
            btnNavReports.Text = "Reports";
            btnNavReports.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReports.UseMnemonic = false;
            btnNavReports.UseVisualStyleBackColor = true;
            // 
            // btnNavSales
            // 
            btnNavSales.Cursor = Cursors.Hand;
            btnNavSales.FlatAppearance.BorderSize = 0;
            btnNavSales.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 160, 125);
            btnNavSales.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 176, 140);
            btnNavSales.FlatStyle = FlatStyle.Flat;
            btnNavSales.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavSales.ForeColor = Color.FromArgb(75, 56, 42);
            btnNavSales.Location = new Point(12, 228);
            btnNavSales.Name = "btnNavSales";
            btnNavSales.Padding = new Padding(14, 0, 0, 0);
            btnNavSales.Size = new Size(196, 42);
            btnNavSales.TabIndex = 4;
            btnNavSales.Text = "Sales & Checkout";
            btnNavSales.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSales.UseMnemonic = false;
            btnNavSales.UseVisualStyleBackColor = true;
            // 
            // btnNavCategories
            // 
            btnNavCategories.Cursor = Cursors.Hand;
            btnNavCategories.FlatAppearance.BorderSize = 0;
            btnNavCategories.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 160, 125);
            btnNavCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 176, 140);
            btnNavCategories.FlatStyle = FlatStyle.Flat;
            btnNavCategories.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavCategories.ForeColor = Color.FromArgb(75, 56, 42);
            btnNavCategories.Location = new Point(12, 182);
            btnNavCategories.Name = "btnNavCategories";
            btnNavCategories.Padding = new Padding(14, 0, 0, 0);
            btnNavCategories.Size = new Size(196, 42);
            btnNavCategories.TabIndex = 3;
            btnNavCategories.Text = "Categories";
            btnNavCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnNavCategories.UseMnemonic = false;
            btnNavCategories.UseVisualStyleBackColor = true;
            // 
            // btnNavBooks
            // 
            btnNavBooks.Cursor = Cursors.Hand;
            btnNavBooks.FlatAppearance.BorderSize = 0;
            btnNavBooks.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 160, 125);
            btnNavBooks.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 176, 140);
            btnNavBooks.FlatStyle = FlatStyle.Flat;
            btnNavBooks.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavBooks.ForeColor = Color.FromArgb(75, 56, 42);
            btnNavBooks.Location = new Point(12, 136);
            btnNavBooks.Name = "btnNavBooks";
            btnNavBooks.Padding = new Padding(14, 0, 0, 0);
            btnNavBooks.Size = new Size(196, 42);
            btnNavBooks.TabIndex = 2;
            btnNavBooks.Text = "Books";
            btnNavBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnNavBooks.UseMnemonic = false;
            btnNavBooks.UseVisualStyleBackColor = true;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Cursor = Cursors.Hand;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 160, 125);
            btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 176, 140);
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavDashboard.ForeColor = Color.FromArgb(75, 56, 42);
            btnNavDashboard.Location = new Point(12, 90);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Padding = new Padding(14, 0, 0, 0);
            btnNavDashboard.Size = new Size(196, 42);
            btnNavDashboard.TabIndex = 0;
            btnNavDashboard.Text = "Dashboard";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.UseMnemonic = false;
            btnNavDashboard.UseVisualStyleBackColor = true;
            // 
            // lblBrandSub
            // 
            lblBrandSub.Font = new Font("Georgia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandSub.ForeColor = Color.FromArgb(94, 70, 49);
            lblBrandSub.Location = new Point(0, 50);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new Size(220, 32);
            lblBrandSub.TabIndex = 1;
            lblBrandSub.Text = "BOOKSTORE MANAGEMENT";
            lblBrandSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrand.ForeColor = Color.FromArgb(75, 56, 42);
            lblBrand.Location = new Point(0, 18);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(220, 20);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "The Reading Room";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(244, 236, 224);
            pnlHeader.Controls.Add(lblAvatar);
            pnlHeader.Controls.Add(lblSignedIn);
            pnlHeader.Controls.Add(lblTrail);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(220, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(764, 70);
            pnlHeader.TabIndex = 2;
            // 
            // lblSignedIn
            // 
            lblSignedIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSignedIn.AutoSize = true;
            lblSignedIn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignedIn.ForeColor = Color.FromArgb(110, 84, 64);
            lblSignedIn.Location = new Point(776, 19);
            lblSignedIn.Name = "lblSignedIn";
            lblSignedIn.Size = new Size(70, 15);
            lblSignedIn.TabIndex = 2;
            lblSignedIn.Text = "Signed in as";
            lblSignedIn.UseMnemonic = false;
            // 
            // lblTrail
            // 
            lblTrail.AutoSize = true;
            lblTrail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrail.ForeColor = Color.FromArgb(110, 84, 64);
            lblTrail.Location = new Point(26, 34);
            lblTrail.Name = "lblTrail";
            lblTrail.Size = new Size(107, 15);
            lblTrail.TabIndex = 1;
            lblTrail.Text = "Home › Dashboard";
            lblTrail.UseMnemonic = false;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Georgia", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(75, 56, 42);
            lblPageTitle.Location = new Point(24, 6);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(144, 27);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            lblPageTitle.UseMnemonic = false;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.ForeColor = Color.FromArgb(22, 22, 22, 22);
            pnlContent.Location = new Point(220, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(764, 589);
            pnlContent.TabIndex = 3;
            // 
            // lblAvatar
            // 
            lblAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAvatar.BackColor = Color.FromArgb(62, 75, 58);
            lblAvatar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvatar.ForeColor = Color.FromArgb(245, 239, 230);
            lblAvatar.Location = new Point(868, 14);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(28, 28);
            lblAvatar.TabIndex = 3;
            lblAvatar.Text = "M";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            lblAvatar.UseMnemonic = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 223, 207);
            ClientSize = new Size(984, 681);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(stsMain);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximumSize = new Size(1000, 720);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Reading Room: Bookstore Management";
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip stsMain;
        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Label lblBrand;
        private Label lblBrandSub;
        private Button btnNavDashboard;
        private Button btnNavSettings;
        private Button btnNavReports;
        private Button btnNavSales;
        private Button btnNavCategories;
        private Button btnNavBooks;
        private Button btnLogout;
        private Label lblPageTitle;
        private Label lblTrail;
        private Label lblSignedIn;
        private Label lblAvatar;
    }
}