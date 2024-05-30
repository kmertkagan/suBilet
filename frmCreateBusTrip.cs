using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suBilet
{
    public partial class frmCreateBusTrip : Form
    {
        public frmCreateBusTrip()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=MERT\SQLEXPRESS;Initial Catalog=buBilet;Integrated Security=True");
        private void frmCreateBusTrip_Load(object sender, EventArgs e)
        {
            datePicker.MinDate= DateTime.Now;

            timePicker.CustomFormat = "HH:mm"; // Only use hours and minutes
            timePicker.ShowUpDown = true;
        }

        private void saveTripButton_Click(object sender, EventArgs e)
        {
            connection.Open();

            string fromcity = fromCityBox.Text;
            string tocity = toCityBox.Text;
            string company = companiesBox.Text;
            DateTime departuredate = datePicker.Value.Date;
            DateTime departuretime = timePicker.Value;
            

            /* 
             * koltuklar 2+1 düzeninde olacak
             * numaralandırmalar ise;
             * 
             * 1    2  3
             * 4    5  6 
             * 7    8  9
             * .
             * .
             * .
             * 22      
             * 23    24 25
             * .     .   .
             * .     .   .
             * .     .   .
             * .     .   .
             * 38 39 40 41
             * 
             * şeklinde ilerleyecektir.
             */
<<<<<<< HEAD

=======
            //dfasdgsagasrgaegaegag
>>>>>>> 8365d5e571e6390779b46f571b3524c500b1f670
            int availableseat = 41;

            try
            {
                string query = "INSERT INTO Buses(fromCity, toCity, departureDate, departureTime, availableSeat, company)" +
                "VALUES(@fromcity, @tocity, @departuredate, @departuretime, @availableseat, @company)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@fromcity", fromcity);
                cmd.Parameters.AddWithValue("@tocity", tocity);
                cmd.Parameters.AddWithValue("@departuredate", departuredate.ToString("yyyy-MM-dd") );
                cmd.Parameters.AddWithValue("@departuretime", departuretime.ToString("HH:mm:ss") );
                cmd.Parameters.AddWithValue("@availableseat", availableseat);
                cmd.Parameters.AddWithValue("@company", company);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sefer Başarıyla Kaydedildi.", "Başarlı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Somethings went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                connection.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
