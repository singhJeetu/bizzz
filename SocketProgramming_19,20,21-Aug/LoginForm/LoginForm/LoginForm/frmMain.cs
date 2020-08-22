using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string name)
        {
            InitializeComponent();
            this.Text = "Welcome " + name + "!";
            //lblWelcome.Text = "Welcome " +name + "!";
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string gender = "";
            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else if (rdoFeMale.Checked)
            {
                gender = "Female";
            }

            string skills = "";
            for (int i = 0; i < chkSkills.CheckedItems.Count; i++)
            {
                skills = skills + chkSkills.CheckedItems[i].ToString() + " ,";
            }
            skills = skills.Trim(',');
            //MessageBox.Show(skills);

            string country = cboCountry.Text;

        }
    }
}
