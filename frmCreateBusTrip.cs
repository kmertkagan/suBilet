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
            InitializeComponent();////
        }

        
        SqlConfig config = new SqlConfig();
        
        private void frmCreateBusTrip_Load(object sender, EventArgs e)
        {
            datePicker.MinDate= DateTime.Now;

            timePicker.CustomFormat = "HH:mm"; // Only use hours and minutes
            timePicker.ShowUpDown = true;
        }

        private void saveTripButton_Click(object sender, EventArgs e)
        {
            config.ToConnect();

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

            int availableseat = 41;

            try
            {
                if (!AnyProblemWithInputs())
                {

                    string query = "INSERT INTO Buses(fromCity, toCity, departureDate, departureTime, availableSeat, company)" +
                    "VALUES(@fromcity, @tocity, @departuredate, @departuretime, @availableseat, @company)";

                    SqlCommand cmd = new SqlCommand(query, config.ToConnect());

                    cmd.Parameters.AddWithValue("@fromcity", fromcity);
                    cmd.Parameters.AddWithValue("@tocity", tocity);
                    cmd.Parameters.AddWithValue("@departuredate", departuredate.ToString("yyyy-MM-dd") );
                    cmd.Parameters.AddWithValue("@departuretime", departuretime.ToString("HH:mm:ss") );
                    cmd.Parameters.AddWithValue("@availableseat", availableseat);
                    cmd.Parameters.AddWithValue("@company", company);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sefer Başarıyla Kaydedildi.", "Başarlı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch 
            {
                MessageBox.Show("Somethings went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private bool AnyProblemWithInputs()
        {
            string[] inputs = {fromCityBox.Text, toCityBox.Text, datePicker.Text, timePicker.Text, companiesBox.Text};
            for (int i = 0 ;i <= inputs.Length; i++) 
            {
                if (String.IsNullOrEmpty(inputs[i]))
                {
                    MessageBox.Show("Tüm Değerleri Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    return true;             
                }

                else if (fromCityBox.Text == toCityBox.Text) 
                {
                    MessageBox.Show("Şehirler Aynı Olamaz!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

    }
}
