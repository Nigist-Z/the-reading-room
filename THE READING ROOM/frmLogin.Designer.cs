namespace THE_READING_ROOM
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnlPhoto = new Panel();
            pnlPlate = new Panel();
            lblPlateTag = new Label();
            lblPlateTitle = new Label();
            pnlForm = new Panel();
            lnkCreate = new LinkLabel();
            lblNew = new Label();
            pnlLine = new Panel();
            btnSubmit = new Button();
            lblError = new Label();
            lnkForgot = new LinkLabel();
            chkKeep = new CheckBox();
            lnkShow = new LinkLabel();
            txtPassword = new TextBox();
            lblPass = new Label();
            txtUsername = new TextBox();
            lblUser = new Label();
            lblSub = new Label();
            lblTitle = new Label();
            lnkBack = new LinkLabel();
            pnlPhoto.SuspendLayout();
            pnlPlate.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPhoto
            // 
            pnlPhoto.BackgroundImage = (Image)resources.GetObject("pnlPhoto.BackgroundImage");
            pnlPhoto.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPhoto.Controls.Add(pnlPlate);
            pnlPhoto.Dock = DockStyle.Left;
            pnlPhoto.Location = new Point(0, 0);
            pnlPhoto.Name = "pnlPhoto";
            pnlPhoto.Size = new Size(450, 590);
            pnlPhoto.TabIndex = 0;
            pnlPhoto.Paint += this.pnlPhoto_Paint;
            // 
            // pnlPlate
            // 
            pnlPlate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlPlate.BackColor = Color.FromArgb(234, 230, 211);
            pnlPlate.BorderStyle = BorderStyle.FixedSingle;
            pnlPlate.Controls.Add(lblPlateTag);
            pnlPlate.Controls.Add(lblPlateTitle);
            pnlPlate.Location = new Point(28, 494);
            pnlPlate.Name = "pnlPlate";
            pnlPlate.Size = new Size(390, 84);
            pnlPlate.TabIndex = 0;
            pnlPlate.Paint += this.pnlPlate_Paint;
            // 
            // lblPlateTag
            // 
            lblPlateTag.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlateTag.ForeColor = Color.FromArgb(110, 84, 64);
            lblPlateTag.Location = new Point(-3, 45);
            lblPlateTag.Name = "lblPlateTag";
            lblPlateTag.Size = new Size(388, 24);
            lblPlateTag.TabIndex = 2;
            lblPlateTag.Text = "The Reading Room";
            lblPlateTag.TextAlign = ContentAlignment.MiddleCenter;
            lblPlateTag.Click += this.lblPlateTag_Click;
            // 
            // lblPlateTitle
            // 
            lblPlateTitle.Font = new Font("Georgia", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPlateTitle.ForeColor = Color.FromArgb(75, 56, 42);
            lblPlateTitle.Location = new Point(3, 9);
            lblPlateTitle.Name = "lblPlateTitle";
            lblPlateTitle.Size = new Size(387, 36);
            lblPlateTitle.TabIndex = 1;
            lblPlateTitle.Text = "“A good bookshop is a place to slow down.”";
            lblPlateTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblPlateTitle.Click += lblPlateTitle_Click;
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(lnkCreate);
            pnlForm.Controls.Add(lblNew);
            pnlForm.Controls.Add(pnlLine);
            pnlForm.Controls.Add(btnSubmit);
            pnlForm.Controls.Add(lblError);
            pnlForm.Controls.Add(lnkForgot);
            pnlForm.Controls.Add(chkKeep);
            pnlForm.Controls.Add(lnkShow);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblPass);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblUser);
            pnlForm.Controls.Add(lblSub);
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(lnkBack);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(450, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(434, 590);
            pnlForm.TabIndex = 1;
            pnlForm.Paint += this.pnlForm_Paint;
            // 
            // lnkCreate
            // 
            lnkCreate.ActiveLinkColor = Color.FromArgb(44, 55, 42);
            lnkCreate.AutoSize = true;
            lnkCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkCreate.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lnkCreate.LinkColor = Color.FromArgb(62, 75, 58);
            lnkCreate.Location = new Point(240, 466);
            lnkCreate.Name = "lnkCreate";
            lnkCreate.Size = new Size(118, 17);
            lnkCreate.TabIndex = 11;
            lnkCreate.TabStop = true;
            lnkCreate.Text = "Create an account";
            lnkCreate.LinkClicked += lnkCreate_LinkClicked;
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNew.ForeColor = Color.FromArgb(110, 84, 64);
            lblNew.Location = new Point(71, 466);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(172, 17);
            lblNew.TabIndex = 10;
            lblNew.Text = "New to The Reading Room?";
            lblNew.Click += this.lblNew_Click;
            // 
            // pnlLine
            // 
            pnlLine.BackColor = Color.FromArgb(201, 180, 151);
            pnlLine.Location = new Point(57, 452);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(320, 1);
            pnlLine.TabIndex = 9;
            pnlLine.Paint += this.pnlLine_Paint;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(62, 75, 58);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(44, 45, 52);
            btnSubmit.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 55, 42);
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 92, 71);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.FromArgb(245, 239, 230);
            btnSubmit.Location = new Point(57, 388);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(320, 46);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Log in";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblError
            // 
            lblError.BackColor = Color.FromArgb(243, 220, 214);
            lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.FromArgb(126, 42, 29);
            lblError.Location = new Point(57, 342);
            lblError.Name = "lblError";
            lblError.Size = new Size(320, 34);
            lblError.TabIndex = 8;
            lblError.TextAlign = ContentAlignment.MiddleLeft;
            lblError.Visible = false;
            lblError.Click += this.lblError_Click;
            // 
            // lnkForgot
            // 
            lnkForgot.ActiveLinkColor = Color.FromArgb(44, 55, 42);
            lnkForgot.AutoSize = true;
            lnkForgot.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lnkForgot.LinkColor = Color.FromArgb(62, 75, 58);
            lnkForgot.Location = new Point(240, 313);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(144, 17);
            lnkForgot.TabIndex = 7;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Forgot your password?";
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
            // 
            // chkKeep
            // 
            chkKeep.AutoSize = true;
            chkKeep.Checked = true;
            chkKeep.CheckState = CheckState.Checked;
            chkKeep.Cursor = Cursors.Hand;
            chkKeep.ForeColor = Color.FromArgb(94, 70, 49);
            chkKeep.Location = new Point(57, 312);
            chkKeep.Name = "chkKeep";
            chkKeep.Size = new Size(136, 21);
            chkKeep.TabIndex = 2;
            chkKeep.Text = "Keep me signed in";
            chkKeep.UseVisualStyleBackColor = true;
            chkKeep.CheckedChanged += this.chkKeep_CheckedChanged;
            // 
            // lnkShow
            // 
            lnkShow.ActiveLinkColor = Color.FromArgb(44, 55, 42);
            lnkShow.AutoSize = true;
            lnkShow.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lnkShow.LinkColor = Color.FromArgb(62, 75, 58);
            lnkShow.Location = new Point(345, 245);
            lnkShow.Name = "lnkShow";
            lnkShow.Size = new Size(39, 17);
            lnkShow.TabIndex = 6;
            lnkShow.TabStop = true;
            lnkShow.Text = "Show";
            lnkShow.LinkClicked += lnkShow_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 253, 248);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(75, 56, 42);
            txtPassword.Location = new Point(57, 266);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 29);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += this.txtPassword_TextChanged;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.FromArgb(94, 70, 49);
            lblPass.Location = new Point(57, 244);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(64, 17);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            lblPass.Click += this.lblPass_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 253, 248);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(75, 56, 42);
            txtUsername.Location = new Point(57, 194);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 29);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += this.txtUsername_TextChanged;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(94, 70, 49);
            lblUser.Location = new Point(57, 172);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(119, 17);
            lblUser.TabIndex = 3;
            lblUser.Text = "Username or email";
            lblUser.Click += this.lblUser_Click;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSub.ForeColor = Color.FromArgb(110, 84, 64);
            lblSub.Location = new Point(57, 128);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(287, 17);
            lblSub.TabIndex = 2;
            lblSub.Text = "Log in with your staff account to open the shop.";
            lblSub.Click += this.lblSub_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(75, 56, 42);
            lblTitle.Location = new Point(53, 72);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "\tWelcome back";
            lblTitle.Click += lblTitle_Click;
            // 
            // lnkBack
            // 
            lnkBack.ActiveLinkColor = Color.FromArgb(62, 75, 58);
            lnkBack.AutoSize = true;
            lnkBack.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkBack.LinkColor = Color.FromArgb(94, 70, 49);
            lnkBack.Location = new Point(57, 40);
            lnkBack.Name = "lnkBack";
            lnkBack.Size = new Size(154, 17);
            lnkBack.TabIndex = 0;
            lnkBack.TabStop = true;
            lnkBack.Text = "← Back to welcome page";
            lnkBack.LinkClicked += lnkBack_LinkClicked;
            // 
            // frmLogin
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 223, 207);
            ClientSize = new Size(884, 590);
            Controls.Add(pnlForm);
            Controls.Add(pnlPhoto);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Reading Room: Staff Login";
            pnlPhoto.ResumeLayout(false);
            pnlPlate.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPhoto;
        private Panel pnlPlate;
        private Label lblPlateTag;
        private Label lblPlateTitle;
        private Panel pnlForm;
        private Label lblTitle;
        private TextBox txtUsername;
        private CheckBox chkKeep;
        private Button btnSubmit;
        private LinkLabel lnkBack;
        private Label lblSub;
        private Label lblUser;
        private TextBox txtPassword;
        private Label lblPass;
        private LinkLabel lnkShow;
        private LinkLabel lnkForgot;
        private Label lblError;
        private Panel pnlLine;
        private Label lblNew;
        private LinkLabel lnkCreate;
    }
}