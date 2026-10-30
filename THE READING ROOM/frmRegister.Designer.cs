namespace THE_READING_ROOM
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            lnkLogin = new LinkLabel();
            lblHave = new Label();
            btnCreate = new Button();
            lblError = new Label();
            txtPassword = new TextBox();
            lblPass = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblSub = new Label();
            lblTitle = new Label();
            lnkBack = new LinkLabel();
            lblPlateTag = new Label();
            lblPlateTitle = new Label();
            pnlPlate = new Panel();
            pnlForm = new Panel();
            lblHint = new Label();
            txtConfirm = new TextBox();
            lblConfirm = new Label();
            cboRole = new ComboBox();
            lblRole = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            pnlPhoto = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pnlPlate.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlPhoto.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lnkLogin
            // 
            lnkLogin.ActiveLinkColor = Color.FromArgb(44, 55, 42);
            lnkLogin.AutoSize = true;
            lnkLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkLogin.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lnkLogin.LinkColor = Color.FromArgb(62, 75, 58);
            lnkLogin.Location = new Point(257, 484);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(47, 17);
            lnkLogin.TabIndex = 11;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Log in";
            lnkLogin.LinkClicked += lnkLogin_LinkClicked;
            // 
            // lblHave
            // 
            lblHave.AutoSize = true;
            lblHave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHave.ForeColor = Color.FromArgb(110, 84, 64);
            lblHave.Location = new Point(95, 484);
            lblHave.Name = "lblHave";
            lblHave.Size = new Size(156, 17);
            lblHave.TabIndex = 10;
            lblHave.Text = "Already have an account?";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(62, 75, 58);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderColor = Color.FromArgb(44, 45, 52);
            btnCreate.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 55, 42);
            btnCreate.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 92, 71);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.FromArgb(245, 239, 230);
            btnCreate.Location = new Point(33, 427);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(360, 44);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblError
            // 
            lblError.BackColor = Color.FromArgb(234, 223, 207);
            lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.FromArgb(155, 54, 38);
            lblError.Location = new Point(37, 362);
            lblError.Name = "lblError";
            lblError.Size = new Size(360, 22);
            lblError.TabIndex = 8;
            lblError.TextAlign = ContentAlignment.MiddleLeft;
            lblError.Visible = false;
            lblError.Click += lblError_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 253, 248);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(75, 56, 42);
            txtPassword.Location = new Point(37, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.FromArgb(94, 70, 49);
            lblPass.Location = new Point(37, 310);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(64, 17);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(255, 253, 248);
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.FromArgb(75, 56, 42);
            txtFullName.Location = new Point(37, 150);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(172, 27);
            txtFullName.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(94, 70, 49);
            lblFullName.Location = new Point(37, 130);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(63, 17);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full name";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSub.ForeColor = Color.FromArgb(110, 84, 64);
            lblSub.Location = new Point(37, 98);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(334, 17);
            lblSub.TabIndex = 2;
            lblSub.Text = "Join the team. An administrator approves new accounts.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(75, 56, 42);
            lblTitle.Location = new Point(33, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Create your account";
            // 
            // lnkBack
            // 
            lnkBack.ActiveLinkColor = Color.FromArgb(62, 75, 58);
            lnkBack.AutoSize = true;
            lnkBack.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkBack.LinkColor = Color.FromArgb(94, 70, 49);
            lnkBack.Location = new Point(37, 26);
            lnkBack.Name = "lnkBack";
            lnkBack.Size = new Size(154, 17);
            lnkBack.TabIndex = 0;
            lnkBack.TabStop = true;
            lnkBack.Text = "← Back to welcome page";
            lnkBack.LinkClicked += lnkBack_LinkClicked;
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
            // 
            // pnlPlate
            // 
            pnlPlate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnlPlate.BackColor = Color.FromArgb(234, 230, 211);
            pnlPlate.BorderStyle = BorderStyle.FixedSingle;
            pnlPlate.Controls.Add(lblPlateTag);
            pnlPlate.Controls.Add(lblPlateTitle);
            pnlPlate.Location = new Point(28, 984);
            pnlPlate.Name = "pnlPlate";
            pnlPlate.Size = new Size(390, 84);
            pnlPlate.TabIndex = 0;
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(lblHint);
            pnlForm.Controls.Add(txtConfirm);
            pnlForm.Controls.Add(lblConfirm);
            pnlForm.Controls.Add(cboRole);
            pnlForm.Controls.Add(lblRole);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(lblEmail);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(lnkLogin);
            pnlForm.Controls.Add(lblHave);
            pnlForm.Controls.Add(btnCreate);
            pnlForm.Controls.Add(lblError);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(lblPass);
            pnlForm.Controls.Add(txtFullName);
            pnlForm.Controls.Add(lblFullName);
            pnlForm.Controls.Add(lblSub);
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(lnkBack);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(434, 590);
            pnlForm.TabIndex = 3;
            // 
            // lblHint
            // 
            lblHint.BackColor = Color.FromArgb(234, 223, 207);
            lblHint.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHint.ForeColor = Color.FromArgb(110, 84, 64);
            lblHint.Location = new Point(37, 388);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(360, 22);
            lblHint.TabIndex = 21;
            lblHint.Text = "Use at least 8 characters, with a number.";
            lblHint.TextAlign = ContentAlignment.MiddleLeft;
            lblHint.Visible = false;
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = Color.FromArgb(255, 253, 248);
            txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirm.ForeColor = Color.FromArgb(75, 56, 42);
            txtConfirm.Location = new Point(224, 330);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(173, 27);
            txtConfirm.TabIndex = 5;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirm.ForeColor = Color.FromArgb(94, 70, 49);
            lblConfirm.Location = new Point(224, 310);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(114, 17);
            lblConfirm.TabIndex = 20;
            lblConfirm.Text = "Confirm Password";
            // 
            // cboRole
            // 
            cboRole.BackColor = Color.FromArgb(255, 253, 248);
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FlatStyle = FlatStyle.Flat;
            cboRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Cashier", "Admin" });
            cboRole.Location = new Point(37, 270);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(360, 28);
            cboRole.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(94, 70, 49);
            lblRole.Location = new Point(37, 246);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(34, 17);
            lblRole.TabIndex = 17;
            lblRole.Text = "Role";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(255, 253, 248);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(75, 56, 42);
            txtEmail.Location = new Point(37, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 29);
            txtEmail.TabIndex = 2;
            txtEmail.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(94, 70, 49);
            lblEmail.Location = new Point(37, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 17);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 253, 248);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(75, 56, 42);
            txtUsername.Location = new Point(224, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(173, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(94, 70, 49);
            lblUsername.Location = new Point(224, 130);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(67, 17);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Username";
            // 
            // pnlPhoto
            // 
            pnlPhoto.BackgroundImage = (Image)resources.GetObject("pnlPhoto.BackgroundImage");
            pnlPhoto.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPhoto.Controls.Add(panel1);
            pnlPhoto.Controls.Add(pnlPlate);
            pnlPhoto.Dock = DockStyle.Right;
            pnlPhoto.Location = new Point(434, 0);
            pnlPhoto.Name = "pnlPhoto";
            pnlPhoto.Size = new Size(450, 590);
            pnlPhoto.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(234, 230, 211);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(32, 494);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 84);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(110, 84, 64);
            label1.Location = new Point(-1, 45);
            label1.Name = "label1";
            label1.Size = new Size(388, 24);
            label1.TabIndex = 2;
            label1.Text = "The Reading Room";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(75, 56, 42);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(387, 36);
            label2.TabIndex = 1;
            label2.Text = "“Every book has a place, and so does every reader.”";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRegister
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 223, 207);
            ClientSize = new Size(884, 590);
            Controls.Add(pnlForm);
            Controls.Add(pnlPhoto);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Reading Room: Create an Account";
            Load += frmRegister_Load;
            pnlPlate.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlPhoto.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel lnkLogin;
        private Label lblHave;
        private Button btnCreate;
        private Label lblError;
        private TextBox txtPassword;
        private Label lblPass;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblSub;
        private Label lblTitle;
        private LinkLabel lnkBack;
        private Label lblPlateTag;
        private Label lblPlateTitle;
        private Panel pnlPlate;
        private Panel pnlForm;
        private Panel pnlPhoto;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblRole;
        private TextBox txtEmail;
        private Label lblEmail;
        private ComboBox cboRole;
        private TextBox txtConfirm;
        private Label lblConfirm;
        private Label lblHint;

        private void lblError_Click(object sender, EventArgs e) { }
        private void frmRegister_Load(object sender, EventArgs e) { }
    }
}
