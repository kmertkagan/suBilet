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
using System.Data.SqlClient;
using System.Security.Cryptography; // for password


namespace buBilet
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=MERT\SQLEXPRESS;Initial Catalog=buBilet;Integrated Security=True");

        private void register_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin sform = new frmLogin();
            sform.Show();
            this.Hide();
        }

        private void xRegister_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_signUpButton_Click(object sender, EventArgs e)
        {
            string name_surname, tcId, gender, username, password, password_confirm;

            name_surname = Register_nameSurname.Text;
            tcId = Register_tcID.Text;
            gender = Register_gender.Text;
            username = Register_username.Text;
            password = Register_pswd.Text;
            password_confirm = Register_pswdConfirm.Text;

            string[] checkList = {name_surname, tcId, gender, username, password, password_confirm};

            

            try
            {
                connection.Open();
                foreach (string i in checkList)
                {
                    if (String.IsNullOrEmpty(i))
                    {
                        MessageBox.Show("Lütfen İstenilen Tüm Bilgileri Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Register_pswd.Text = "";
                        Register_pswdConfirm.Text = "";
                        break;
                    }
                    else if (password != password_confirm)
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Register_pswd.Text = "";
                        Register_pswdConfirm.Text = "";
                        break;
                    }
                    else if (int.TryParse(tcId, out int num) != true || tcId.Length != 11) ;
                    {
                        MessageBox.Show("TC Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Register_pswd.Text = "";
                        Register_pswdConfirm.Text = "";
                        break;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Something went wrong");
            }
            finally 
            { 
                connection.Close();
            }
            

        }

        private void Register_showPswd_CheckedChanged(object sender, EventArgs e)
        {
            if (Register_showPswd.Checked)
            {
                Register_pswd.UseSystemPasswordChar = false;
                Register_pswdConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                Register_pswd.UseSystemPasswordChar = true;
                Register_pswdConfirm.UseSystemPasswordChar = true;
            }
        }        
    }
}
