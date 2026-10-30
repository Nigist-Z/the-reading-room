using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace THE_READING_ROOM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblPlateTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (user == "")
            {
                ShowError("Please enter your username.");
                txtUsername.Focus();
                return;
            }
            if (pass == "")
            {
                ShowError("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            // Temporary accounts. We will replace these later.
            bool isAdmin = user == "admin" && pass == "admin123";
            bool isCashier = user == "cashier" && pass == "cashier123";

            if (!isAdmin && !isCashier)
            {
                ShowError("The username or password is incorrect. Try again.");
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            lblError.Visible = false;
            Session.UserName = user;
            Session.Role = isAdmin ? "Admin" : "Cashier";
            DialogResult = DialogResult.OK;   // closes the login form and tells the welcome page it workeds
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void lnkShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool wasHidden = txtPassword.UseSystemPasswordChar;
            txtPassword.UseSystemPasswordChar = !wasHidden;
            lnkShow.Text = wasHidden ? "Hide" : "Show";
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please ask the shop administrator to reset your password.", "Forgot password");
        }

        private void lnkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegister().ShowDialog();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        // Empty methods the designer is still pointing at. They do nothing.
        private void pnlPhoto_Paint(object sender, PaintEventArgs e) { }
        private void pnlPlate_Paint(object sender, PaintEventArgs e) { }
        private void pnlForm_Paint(object sender, PaintEventArgs e) { }
        private void pnlLine_Paint(object sender, PaintEventArgs e) { }
        private void lblPlateTag_Click(object sender, EventArgs e) { }
        private void lblNew_Click(object sender, EventArgs e) { }
        private void lblError_Click(object sender, EventArgs e) { }
        private void lblPass_Click(object sender, EventArgs e) { }
        private void lblUser_Click(object sender, EventArgs e) { }
        private void lblSub_Click(object sender, EventArgs e) { }
        private void chkKeep_CheckedChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
    }
}
