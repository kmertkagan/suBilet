using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suBilet
{
    public partial class frmDeleteBusTrip : Form
    {
        public frmDeleteBusTrip()
        {
            InitializeComponent();
        }

        SqlConfig config = new SqlConfig();
        internal string Id { get; set; }

        private void frmDeleteBusTrip_Load(object sender, EventArgs e)
        {
            
            string queryforbuses = "SELECT busId, fromCity AS Nereden, toCity AS Nereye, " +
                    "departureDate AS [Kalkış Tarihi], CONVERT(VARCHAR(5), departureTime, 108) AS [Kalkış Saati], availableSeat AS [Kalan Koltuk], " +
                    "company AS Firma FROM Buses";
            SqlCommand cmdbus = new SqlCommand(queryforbuses, config.ToConnect());


            SqlDataAdapter adapterbus = new SqlDataAdapter(cmdbus);
            DataTable dtbus = new DataTable();

            adapterbus.Fill(dtbus);

            busesdgw.DataSource = dtbus;

            busesdgw.ReadOnly= true;
            busesdgw.Columns["BusId"].Visible = false;
        }

        private void busesdgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string busId, fromcity, tocity, date, time, persons, company;

                busId = busesdgw.CurrentRow.Cells[0].Value.ToString();
                fromcity = busesdgw.CurrentRow.Cells[1].Value.ToString();
                tocity = busesdgw.CurrentRow.Cells[2].Value.ToString();
                date = busesdgw.CurrentRow.Cells[3].Value.ToString();
                time = busesdgw.CurrentRow.Cells[4].Value.ToString();
                persons = busesdgw.CurrentRow.Cells[5].Value.ToString();
                company = busesdgw.CurrentRow.Cells[6].Value.ToString();

                var msbx = MessageBox.Show($"{fromcity}-{tocity} Arasında, {date}{time} Tarihli, {company} Firmasının seferini silmek istediğinize emin misiniz?\nNot: {41 - Convert.ToInt64(persons)} kişinin bu otobüste bileti var", "Soru", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msbx==DialogResult.OK) 
                {
                    string deletequery1 = "DELETE FROM Buses WHERE busId = @busId";
                    string deletequery2 = "DELETE FROM Reservation WHERE busId = @busId";
                    SqlCommand cmd1 = new SqlCommand(deletequery1, config.ToConnect());
                    SqlCommand cmd2 = new SqlCommand(deletequery2, config.ToConnect());
                    cmd1.Parameters.AddWithValue("@busId", busId);
                    cmd2.Parameters.AddWithValue("@busId", busId);
                    int afect1 = cmd1.ExecuteNonQuery();
                    int afect2 = cmd2.ExecuteNonQuery();
                    if (afect1 > 0 || afect2 > 0) 
                    {
                        MessageBox.Show($"Silme İşlemi Başarılı\n{afect1}-{afect2}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmDeleteBusTrip_Load(sender, e);
                    }

                }
            }
            catch 
            {
                MessageBox.Show("Something went wrong", "Error");
            }
            finally { config.ToConnect().Close(); }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
