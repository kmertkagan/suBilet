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
using System.Data.SqlTypes;
using System.Drawing.Imaging;
using System.ComponentModel.Design.Serialization;

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
            bool isAdmin = false;
            


            name_surname = Register_nameSurname.Text;
            tcId = Register_tcID.Text;
            gender = Register_gender.Text;
            username = Register_username.Text;
            password = Register_pswd.Text;
            password_confirm = Register_pswdConfirm.Text;


            string[] checkList = {name_surname, tcId, gender, username, password, password_confirm};
            bool AnyNulls = false;
            

            try
            {
                connection.Open();

                foreach (string i in checkList)
                {
                    if (String.IsNullOrEmpty(i))
                    {
                        AnyNulls = true;
                        MessageBox.Show("Lütfen İstenilen Tüm Bilgileri Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Register_pswd.Text = "";
                        Register_pswdConfirm.Text = "";
                        break;
                    }                    
                }

                if (password != password_confirm && AnyNulls == false)
                {
                    MessageBox.Show("Şifreler Uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Register_pswd.Text = "";
                    Register_pswdConfirm.Text = "";

                }
                else if ((long.TryParse(tcId, out long num) == false || tcId.Length != 11) && AnyNulls == false)
                {
                    MessageBox.Show("TC Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Register_pswd.Text = "";
                    Register_pswdConfirm.Text = "";
                }
                else if ( DbCheck(tcId, username) == true) 
                {
                    MessageBox.Show("Bu kullanıcı sistemde mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Register_pswd.Text = "";
                    Register_pswdConfirm.Text = "";
                }


                else 
                {
                    string query = "INSERT INTO Users(name_surname, tcId, gender, username, password, isAdmin) VALUES(@name_surname, @tcId, @gender, @username, @password, @isAdmin)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@name_surname", name_surname);
                    cmd.Parameters.AddWithValue("@tcId", tcId);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@isAdmin", isAdmin);

                    int affectedRows = cmd.ExecuteNonQuery();
                    
                    if (affectedRows != 0 ) 
                    {
                        MessageBox.Show("Kayıt Başarıyla Tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmLogin transaction = new frmLogin();
                        transaction.Show();
                        this.Hide();
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

        public bool DbCheck(string tcId, string username)
        {
            string query = $"SELECT * FROM Users WHERE tcId = @tcId OR username = @username";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@tcId", tcId);
            cmd.Parameters.AddWithValue("@username", username);

            SqlDataAdapter recievedData = new SqlDataAdapter(cmd);
            DataTable TempDT = new DataTable();

            recievedData.Fill(TempDT);

            if (TempDT.Rows.Count > 0) { return true;}
            else { return false; }

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
