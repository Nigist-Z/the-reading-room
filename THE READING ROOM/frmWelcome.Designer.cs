namespace THE_READING_ROOM
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            pnlTop = new Panel();
            pnlSpine3 = new Panel();
            pnlSpine2 = new Panel();
            pnlSpine1 = new Panel();
            button2 = new Button();
            btnTopLogin = new Button();
            lblLogo = new Label();
            pnlLeft = new Panel();
            btnRegister = new Button();
            lblNote = new Label();
            lblEyebrow = new Label();
            lblHeadline = new Label();
            lblIntro = new Label();
            btnLogin = new Button();
            pnlBottom = new Panel();
            lblFeat3Text = new Label();
            lblFeat2Title = new Label();
            lblFeat3Title = new Label();
            lblFeat1Text = new Label();
            lblFeat1Title = new Label();
            lblFeat2Text = new Label();
            pnlRight = new Panel();
            picCollage = new PictureBox();
            pnlTop.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCollage).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(pnlSpine3);
            pnlTop.Controls.Add(pnlSpine2);
            pnlTop.Controls.Add(pnlSpine1);
            pnlTop.Controls.Add(button2);
            pnlTop.Controls.Add(btnTopLogin);
            pnlTop.Controls.Add(lblLogo);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.MaximumSize = new Size(0, 70);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1337, 70);
            pnlTop.TabIndex = 0;
            // 
            // pnlSpine3
            // 
            pnlSpine3.BackColor = Color.FromArgb(140, 59, 43);
            pnlSpine3.Location = new Point(87, 28);
            pnlSpine3.Name = "pnlSpine3";
            pnlSpine3.Size = new Size(7, 28);
            pnlSpine3.TabIndex = 10;
            // 
            // pnlSpine2
            // 
            pnlSpine2.BackColor = Color.FromArgb(169, 132, 103);
            pnlSpine2.Location = new Point(74, 22);
            pnlSpine2.Name = "pnlSpine2";
            pnlSpine2.Size = new Size(7, 34);
            pnlSpine2.TabIndex = 9;
            // 
            // pnlSpine1
            // 
            pnlSpine1.BackColor = Color.FromArgb(62, 75, 58);
            pnlSpine1.Location = new Point(58, 26);
            pnlSpine1.Name = "pnlSpine1";
            pnlSpine1.Size = new Size(10, 30);
            pnlSpine1.TabIndex = 8;
            pnlSpine1.Paint += pnlSpine1_Paint;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(62, 75, 58);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(44, 55, 42);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 55, 42);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 92, 71);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(245, 239, 230);
            button2.Location = new Point(1184, 16);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 2;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnRegister_Click;
            // 
            // btnTopLogin
            // 
            btnTopLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTopLogin.BackColor = Color.FromArgb(241, 232, 218);
            btnTopLogin.Cursor = Cursors.Hand;
            btnTopLogin.FlatAppearance.BorderColor = Color.FromArgb(126, 95, 69);
            btnTopLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 176, 140);
            btnTopLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 195, 165);
            btnTopLogin.FlatStyle = FlatStyle.Flat;
            btnTopLogin.ForeColor = Color.FromArgb(75, 56, 42);
            btnTopLogin.Location = new Point(1033, 16);
            btnTopLogin.Name = "btnTopLogin";
            btnTopLogin.Size = new Size(110, 40);
            btnTopLogin.TabIndex = 1;
            btnTopLogin.Text = "Log in";
            btnTopLogin.UseVisualStyleBackColor = false;
            btnTopLogin.Click += btnLogin_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.FromArgb(75, 56, 42);
            lblLogo.Location = new Point(100, 27);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(250, 29);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "The Reading Room";
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(btnRegister);
            pnlLeft.Controls.Add(lblNote);
            pnlLeft.Controls.Add(lblEyebrow);
            pnlLeft.Controls.Add(lblHeadline);
            pnlLeft.Controls.Add(lblIntro);
            pnlLeft.Controls.Add(btnLogin);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 70);
            pnlLeft.MaximumSize = new Size(560, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(560, 431);
            pnlLeft.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(241, 232, 218);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(126, 95, 69);
            btnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 176, 140);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 195, 165);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(75, 56, 42);
            btnRegister.Location = new Point(310, 413);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(190, 52);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Create an account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(65, 468);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(415, 17);
            lblNote.TabIndex = 7;
            lblNote.Text = "For shop staff. New accounts begin with cashier access and are kept in memory.";
            // 
            // lblEyebrow
            // 
            lblEyebrow.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEyebrow.ForeColor = Color.FromArgb(110, 84, 64);
            lblEyebrow.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblEyebrow.Location = new Point(40, 23);
            lblEyebrow.Name = "lblEyebrow";
            lblEyebrow.Size = new Size(281, 34);
            lblEyebrow.TabIndex = 2;
            lblEyebrow.Text = "Bookstore management";
            lblEyebrow.Click += lblEyebrow_Click;
            // 
            // lblHeadline
            // 
            lblHeadline.Font = new Font("Georgia", 39.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeadline.ForeColor = Color.FromArgb(75, 56, 42);
            lblHeadline.Location = new Point(40, 57);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new Size(480, 150);
            lblHeadline.TabIndex = 3;
            lblHeadline.Text = "Every book has a place.";
            lblHeadline.Click += label2_Click;
            // 
            // lblIntro
            // 
            lblIntro.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblIntro.Location = new Point(40, 207);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(440, 90);
            lblIntro.TabIndex = 4;
            lblIntro.Text = "A calm, simple way to keep your shelves in order, ring up sales, and always know what is running low.";
            lblIntro.Click += lblIntro_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(62, 75, 58);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(44, 55, 42);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 55, 42);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 92, 71);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(245, 239, 230);
            btnLogin.Location = new Point(65, 413);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(210, 52);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log in to the shop";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(244, 236, 224);
            pnlBottom.Controls.Add(lblFeat3Text);
            pnlBottom.Controls.Add(lblFeat2Title);
            pnlBottom.Controls.Add(lblFeat3Title);
            pnlBottom.Controls.Add(lblFeat1Text);
            pnlBottom.Controls.Add(lblFeat1Title);
            pnlBottom.Controls.Add(lblFeat2Text);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 501);
            pnlBottom.MaximumSize = new Size(0, 110);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1337, 100);
            pnlBottom.TabIndex = 14;
            // 
            // lblFeat3Text
            // 
            lblFeat3Text.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeat3Text.Location = new Point(975, 40);
            lblFeat3Text.Name = "lblFeat3Text";
            lblFeat3Text.Size = new Size(300, 60);
            lblFeat3Text.TabIndex = 14;
            lblFeat3Text.Text = "Reports show your best sellers, low stock, and every sale made.";
            lblFeat3Text.Click += lblFeat3Text_Click;
            // 
            // lblFeat2Title
            // 
            lblFeat2Title.AutoSize = true;
            lblFeat2Title.Font = new Font("Georgia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeat2Title.Location = new Point(594, 14);
            lblFeat2Title.Name = "lblFeat2Title";
            lblFeat2Title.Size = new Size(136, 20);
            lblFeat2Title.TabIndex = 10;
            lblFeat2Title.Text = "Ring up a sale";
            // 
            // lblFeat3Title
            // 
            lblFeat3Title.AutoSize = true;
            lblFeat3Title.Font = new Font("Georgia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeat3Title.Location = new Point(1033, 11);
            lblFeat3Title.Name = "lblFeat3Title";
            lblFeat3Title.Size = new Size(132, 20);
            lblFeat3Title.TabIndex = 11;
            lblFeat3Title.Text = "See what sold";
            // 
            // lblFeat1Text
            // 
            lblFeat1Text.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeat1Text.Location = new Point(65, 40);
            lblFeat1Text.Name = "lblFeat1Text";
            lblFeat1Text.Size = new Size(300, 60);
            lblFeat1Text.TabIndex = 12;
            lblFeat1Text.Text = "Add books, sort them into categories, and see at a glance what is in stock.";
            // 
            // lblFeat1Title
            // 
            lblFeat1Title.AutoSize = true;
            lblFeat1Title.Font = new Font("Georgia", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeat1Title.Location = new Point(74, 14);
            lblFeat1Title.Name = "lblFeat1Title";
            lblFeat1Title.Size = new Size(238, 20);
            lblFeat1Title.TabIndex = 9;
            lblFeat1Title.Text = "Keep the shelves in order";
            lblFeat1Title.Click += lblFeat1Title_Click;
            // 
            // lblFeat2Text
            // 
            lblFeat2Text.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeat2Text.Location = new Point(538, 40);
            lblFeat2Text.Name = "lblFeat2Text";
            lblFeat2Text.Size = new Size(300, 60);
            lblFeat2Text.TabIndex = 13;
            lblFeat2Text.Text = "Pick a book, set the quantity, and the stock updates itself.";
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(picCollage);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(560, 70);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(777, 431);
            pnlRight.TabIndex = 2;
            // 
            // picCollage
            // 
            picCollage.BackgroundImageLayout = ImageLayout.None;
            picCollage.Image = (Image)resources.GetObject("picCollage.Image");
            picCollage.Location = new Point(16, 6);
            picCollage.Name = "picCollage";
            picCollage.Size = new Size(749, 502);
            picCollage.SizeMode = PictureBoxSizeMode.Zoom;
            picCollage.TabIndex = 0;
            picCollage.TabStop = false;
            picCollage.Click += picCollage_Click;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 223, 207);
            ClientSize = new Size(1337, 601);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTop);
            Controls.Add(pnlBottom);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(110, 84, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(56, 260);
            MinimizeBox = false;
            Name = "frmWelcome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "The Reading Room";
            WindowState = FormWindowState.Maximized;
            Load += frmWelcome_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCollage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblLogo;
        private Button button2;
        private Button btnTopLogin;
        private Panel pnlLeft;
        private Label lblEyebrow;
        private Label lblHeadline;
        private Label lblIntro;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblNote;
        private Panel pnlRight;
        private PictureBox picCollage;
        private Label lblFeat1Title;
        private Label lblFeat2Title;
        private Label lblFeat3Title;
        private Label lblFeat1Text;
        private Label lblFeat2Text;
        private Label lblFeat3Text;
        private Panel pnlBottom;
        private Panel pnlSpine1;
        private Panel pnlSpine3;
        private Panel pnlSpine2;
    }
}