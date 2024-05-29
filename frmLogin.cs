using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using suBilet;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace buBilet
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MERT\SQLEXPRESS;Initial Catalog=buBilet;Integrated Security=True");

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


        // using in mainpage
        public DataRow userRow { get; set; }
        private void Login_loginButton_Click(object sender, EventArgs e)
        {
            string username, password;

            username = Login_username.Text;
            password = Login_pswd.Text;
                        

            try
            {
                string query = "SELECT * FROM Users WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter recievedData = new SqlDataAdapter(cmd);
                DataTable TempDT = new DataTable();


                recievedData.Fill(TempDT);
                
                if (TempDT.Rows.Count > 0)
                {
                    
                     
                    userRow = TempDT.Rows[0];

                    MessageBox.Show($"Hoşgeldiniz {userRow["username"]}", "Giriş Başarılı", MessageBoxButtons.OK);
                    
                    if (Convert.ToBoolean(userRow["isAdmin"]) == true) 
                    {
                        frmAdminMain transfrm = new frmAdminMain();
                        transfrm.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmMain transfrm = new frmMain();
                        transfrm.Id = Convert.ToString(userRow["id"]);
                        transfrm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Giriş Hatası", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Somethings went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
