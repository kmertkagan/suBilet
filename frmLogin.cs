using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace buBilet
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void login_to_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister sform = new frmRegister();
            sform.Show();
            this.Hide();
        }

        private void xLabel_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Login_loginButton_Click(object sender, EventArgs e)
        {

        }

        private void Login_showPswd_CheckedChanged(object sender, EventArgs e)
        {
            if (Login_showPswd.Checked)
            {
                Login_pswd.UseSystemPasswordChar = false;
            }
            else 
            {
                Login_pswd.UseSystemPasswordChar=true;
            }
        }
    }
}
