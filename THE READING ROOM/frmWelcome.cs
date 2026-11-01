using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace THE_READING_ROOM
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblEyebrow_Click(object sender, EventArgs e)
        {

        }

        private void picCollage_Click(object sender, EventArgs e)
        {

        }

        private void lblFeat1Title_Click(object sender, EventArgs e)
        {

        }

        private void lblIntro_Click(object sender, EventArgs e)
        {

        }

        private void lblFeat2Title_Click(object sender, EventArgs e)
        {

        }

        private void lblFeat3Text_Click(object sender, EventArgs e)
        {

        }

        private void pnlSpine1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                var main = new frmMain();
                main.ShowDialog();
                if (!main.LoggedOut)
                {
                    Close();      // the user closed the app from the main window
                    return;
                }
            }
            Show();               // back to the welcome page
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenForm(new frmRegister());
        }

        // Hides the welcome page, shows the next form, and brings the welcome page back when it closes.
        private void OpenForm(Form next)
        {
            Hide();
            next.ShowDialog();
            Show();
        }
    }
}
