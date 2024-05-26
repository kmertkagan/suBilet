using buBilet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        internal string Id { get; set; }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = DateTime.Now;
        }

    }
}
