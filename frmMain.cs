using buBilet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace suBilet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlConfig config = new SqlConfig();


        // identifying user's id num whose logged in 
        internal string Id { get; set; }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = DateTime.Now;
            string queryforuser = "SELECT * FROM Users WHERE id = @id ";
            SqlCommand cmd = new SqlCommand(queryforuser, config.ToConnect());
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Id) );
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            userinfoLabel.Text = $"Hoşgeldiniz {dt.Rows[0]["name_surname"]}"; 


            try
            {
                // for available buses
                string queryforbuses = "SELECT fromCity AS Nereden, toCity AS Nereye, " +
                    "departureDate AS [Kalkış Tarihi], DepartureTime AS [Kalkış Saati], availableSeat AS [Kalan Koltuk], " +
                    "company AS Firma FROM Buses";
                SqlCommand cmdbus = new SqlCommand(queryforbuses, config.ToConnect());
                SqlDataAdapter adapterbus = new SqlDataAdapter(cmdbus);
                DataTable dtbus = new DataTable();
                adapterbus.Fill(dtbus);

                // deleting expired depart
                /*
                 -------------------------------------------
                 */

                bussesDgw.DataSource = dtbus;

                // disable editing;
                bussesDgw.ReadOnly = true;
                // bussesDgw.Columns["Otobüs Numarası"].Visible = true; 

            }
            catch 
            {
                MessageBox.Show("Somethings went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                config.ToConnect().Close();
            }

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            
            string fromcity, tocity;
            fromcity = FromCity.Text;
            tocity = ToCity.Text;

            // i dunno how i use datagridview so sending query to db again :(
            string queryforbuses = "SELECT fromCity AS Nereden, toCity AS Nereye, " +
                    "departureDate AS [Kalkış Tarihi], DepartureTime AS [Kalkış Saati], availableSeat AS [Kalan Koltuk], " +
                    "company AS Firma FROM Buses WHERE departureDate = @date AND fromCity = @fromcity AND toCity = @tocity";
            SqlCommand cmdbus = new SqlCommand(queryforbuses, config.ToConnect());
            cmdbus.Parameters.AddWithValue("@date", date);
            cmdbus.Parameters.AddWithValue("@fromcity", fromcity);
            cmdbus.Parameters.AddWithValue("@tocity", tocity);


            SqlDataAdapter adapterbus = new SqlDataAdapter(cmdbus);
            DataTable dtbus = new DataTable();

            adapterbus.Fill(dtbus);
            bussesDgw.DataSource = dtbus;
        }
    }
}
