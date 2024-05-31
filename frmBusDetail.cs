using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        SqlConfig config = new SqlConfig();

        private void frmBusDetail_Load(object sender, EventArgs e)
        {

            string busquery = "SELECT busId, fromCity, toCity, CONVERT(VARCHAR, departureDate, 105) AS departureDate, " +
                "CONVERT(VARCHAR(5), departureTime, 108) AS departureTime, availableSeat, company FROM Buses WHERE busId = @busId";
            SqlCommand cmd = new SqlCommand(busquery, config.ToConnect());
            cmd.Parameters.AddWithValue("@busId", busId);  
            SqlDataAdapter dataAdapter= new SqlDataAdapter(cmd);   
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
                foreach (Control cntrl in panel1.Controls) // looping buttons
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

                            if (usersdt.Rows[0]["gender"].ToString() == "Erkek") { btn.BackColor = Color.FromArgb(153, 180, 209); }
                            else { btn.BackColor = Color.Pink; }
                            btn.Enabled = false;
                            
                        }
                    }
                }
            }
            /////
            ///

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /// 
        }
    }
}
