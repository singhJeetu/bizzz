using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                errMessage.SetError(txtUsername, "Required");
                txtUsername.Focus();
            }
            else if (txtPassword.Text == string.Empty)
            {
                errMessage.Clear();
                errMessage.SetError(txtPassword, "Required");
                txtPassword.Focus();
            }
            else if (txtUsername.Text == "jeetu" && txtPassword.Text == "singh")
            {
                frmMain main = new frmMain(txtUsername.Text);
                main.Show();
                this.Hide();

            }
            else
            {
                lblMsg.Text = "username or password is incorrect";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}