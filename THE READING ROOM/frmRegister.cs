using System.Drawing;
using System.Windows.Forms;

namespace THE_READING_ROOM;

public partial class frmRegister : Form
{
    public frmRegister()
    {
        InitializeComponent();
        cboRole.Items.Clear();
        cboRole.Items.Add("Cashier");
        cboRole.SelectedIndex = 0;
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        lblError.Visible = false;
        txtConfirm.BackColor = Color.FromArgb(255, 253, 248);

        string fullName = txtFullName.Text.Trim();
        string username = txtUsername.Text.Trim();
        string email = txtEmail.Text.Trim();
        string pass = txtPassword.Text;

        if (fullName == "")
        {
            ShowError("Please enter your full name.", txtFullName);
            return;
        }
        if (username.Length < 3)
        {
            ShowError("Choose a username with at least 3 characters.", txtUsername);
            return;
        }
        if (!email.Contains("@") || !email.Contains("."))
        {
            ShowError("Please enter a valid email address.", txtEmail);
            return;
        }
        if (pass.Length < 8 || !HasDigit(pass))
        {
            ShowError("Use at least 8 characters, with a number.", txtPassword);
            return;
        }
        if (pass != txtConfirm.Text)
        {
            ShowError("Passwords do not match.", txtConfirm);
            txtConfirm.BackColor = Color.FromArgb(255, 246, 243);
            return;
        }

        if (!Session.RegisterCashier(username, pass))
        {
            ShowError("That username is already in use. Choose another one.", txtUsername);
            return;
        }

        MessageBox.Show("Cashier account created for " + fullName +
            ". You can sign in now. Accounts are kept in memory until the app closes.",
            "Registration complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Close();
    }

    private void ShowError(string message, Control field)
    {
        lblError.Text = message;
        lblError.Visible = true;
        field.Focus();
    }

    private static bool HasDigit(string text)
    {
        foreach (char c in text)
        {
            if (char.IsDigit(c)) return true;
        }
        return false;
    }

    private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Close();
    }

    private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Close();
    }
}