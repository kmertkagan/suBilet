using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suBilet
{
    public partial class frmBusDetail : Form
    {
        public frmBusDetail()
        {
            InitializeComponent();
        }

        internal string Id { get; set; } //userId
        internal string busId { get; set; }
        internal string availableSeat { get; set; }

        SqlConfig config = new SqlConfig();

        // button click counts in dictionary 
        private Dictionary<Button, int> buttonClickCounts = new Dictionary<Button, int>();
        private void frmBusDetail_Load(object sender, EventArgs e)
        {
            // button click checks
            foreach (Control cntrls in panel1.Controls)
            {
                if (cntrls is Button possibleclickedbtns)
                {
                    buttonClickCounts[possibleclickedbtns] = 0; // 
                    possibleclickedbtns.Click += Button_Click;  // Butonun Click olayına Button_Click metodunu ekler.  

                }
            }



            string busquery = "SELECT busId, fromCity, toCity, CONVERT(VARCHAR, departureDate, 105) AS departureDate, " +
            "CONVERT(VARCHAR(5), departureTime, 108) AS departureTime, availableSeat, company FROM Buses WHERE busId = @busId";
            SqlCommand cmd = new SqlCommand(busquery, config.ToConnect());
            cmd.Parameters.AddWithValue("@busId", busId);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            DateTime date = DateTime.ParseExact(dt.Rows[0]["departureDate"].ToString(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string showDate = date.ToString("dd-MM-yyyy dddd");


            label1.Text = $" {dt.Rows[0]["company"]}";
            label2.Text = $" {showDate} - {dt.Rows[0]["departureTime"]}";
            label3.Text = $" {dt.Rows[0]["fromCity"]} - {dt.Rows[0]["toCity"]}";
            label4.Text = $" {dt.Rows[0]["availableSeat"]}";

            // filling unavailable seats;

            string query = $"SELECT * FROM Reservation WHERE busId = @busId";
            SqlCommand cmd2 = new SqlCommand(query, config.ToConnect());
            cmd2.Parameters.AddWithValue("@busId", busId);
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();

            dataAdapter2.Fill(dt2);


            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                foreach (Control cntrl in panel1.Controls) // loop of buttons
                {
                    if (cntrl is Button btn)
                    {
                        if (btn.Text == dt2.Rows[i]["seatId"].ToString())
                        {
                            string userquery = $"SELECT * FROM Users WHERE id = @id";
                            SqlCommand usercmd = new SqlCommand(userquery, config.ToConnect());
                            usercmd.Parameters.AddWithValue("@id", dt2.Rows[i]["id"]);
                            SqlDataAdapter dataAdapter3 = new SqlDataAdapter(usercmd);
                            DataTable usersdt = new DataTable();

                            dataAdapter3.Fill(usersdt);

                            // buttons color change
                            if (usersdt.Rows[0]["gender"].ToString() == "Erkek") { btn.BackColor = Color.FromArgb(0, 191, 255); }
                            else { btn.BackColor = Color.Pink; }
                            btn.Enabled = false;

                            // controlling reservation conflicts
                            if (usersdt.Rows[0]["id"].ToString() == Id)
                            {
                                MessageBox.Show("Bu Otobüste Zaten Hali Hazırda Biletiniz Var", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
        
        private void Button_Click(object sender, EventArgs e)
        {
            /*
             Button_Click metodu, bir butona tıklandığında çalışır.
            sender, tıklanan butondur. 

            Bu parametre, object türündedir ve tıklama olayını başlatan kontrolü belirtir.
            sender as Button, sender nesnesini Button türüne dönüştürmeye çalışır. Eğer sender bir Button ise, clickedButton değişkeni Button türünde olur. 
            Değilse clickedButton null olur. Bu, güvenli bir tür dönüştürme yöntemidir.
            Eğer sender gerçekten bir Button değilse, as operatörü null döner ve if kontrolü sayesinde programın çökmesi engellenir.
            Eğer clickedButton null değilse (yani tıklanan kontrol gerçekten bir butonsa):
            buttonClickCounts sözlüğünde, tıklanan butonun tıklama sayısını 1 artırır. 
            
            (From ChatGPT)

            (sender as Button ? -> sender'ı buton'a çevirmeye çalışmaktır. eğer çevirmezse program çalışmaya devam eder)
            (Button)sender ? -> ama bunda çeviremezse program "InvalidCastException" fırlatır
            */

            // clickedbutton sender ile alındı. 
            Button clickedButton = sender as Button; 
            if (clickedButton != null)
            {
                // button tıklama sayısı artar
                buttonClickCounts[clickedButton]++;
                /*
                    MessageBox.Show($"{clickedButton.Text} clicked {buttonClickCounts[clickedButton]} times!");
                 */ 



                // odd values click
                foreach (Control control in panel1.Controls)
                {
                    if (control is Button btn) 
                    {
                        btn.Enabled = false;
                        if (buttonClickCounts[clickedButton] % 1 == 0 && btn.Text == clickedButton.Text)                     
                        {
                            btn.Enabled = true;
                            btn.BackColor= Color.Gray;
                        }
                    }
                }

                // even values click
                if (buttonClickCounts[clickedButton] % 2 == 0) 
                {
                    foreach (Control control in panel1.Controls)
                    {
                        if (control is Button btn)
                        {
                            if (btn.BackColor == Color.Pink || btn.BackColor == Color.FromArgb(0, 191, 255) )
                            {
                                btn.Enabled= false;
                            }
                            else
                            {
                                btn.Enabled = true;
                                if ( btn.BackColor == Color.Gray ) { btn.BackColor = Color.White; }
                            }
                        }
                    }
                }


            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                config.ToConnect();
                string query = "INSERT INTO Reservation(id, busId, seatId) VALUES(@id, @busId, @seatId)";
                string updateQuery = "UPDATE Buses SET availableSeat = @newSeats WHERE busId = @busId";
                SqlCommand cmd = new SqlCommand(query, config.ToConnect());
                SqlCommand updatecmd = new SqlCommand(updateQuery, config.ToConnect());

                foreach (Control ctrl in panel1.Controls)                
                {
                    if (ctrl is Button btn) 
                    {
                        if (btn.BackColor == Color.Gray)
                        {
                            string seatId = btn.Text;
                            if (!String.IsNullOrEmpty(seatId)) 
                            { 
                                cmd.Parameters.AddWithValue("@seatId", seatId);
                                break;
                            }
                        }
                    }
                }
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@busId", busId);
                int affectedrows = cmd.ExecuteNonQuery();
                if (affectedrows > 0) 
                { 
                    MessageBox.Show("Biletiniz Başarıyla Alındı.", "Başarılı", MessageBoxButtons.OK);
                    updatecmd.Parameters.AddWithValue("@busId", busId);
                    updatecmd.Parameters.AddWithValue("@newSeats", (Convert.ToInt32(availableSeat) - 1).ToString() );
                    updatecmd.ExecuteNonQuery();
                    this.Close(); 
                }
            }
            catch 
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                config.ToConnect().Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
