﻿using buBilet;
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
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }

        SqlConfig config = new SqlConfig();

        
        // identifying user's id num whose logged in
        internal string Id { get; set; }
        private void createBusTrip_Click(object sender, EventArgs e)
        {
            frmCreateBusTrip cbt = new frmCreateBusTrip();
            cbt.Show();
        }

        private void deleteBusTrip_Click(object sender, EventArgs e)
        {
            frmDeleteBusTrip dbt = new frmDeleteBusTrip();
            dbt.Id= Id;
            dbt.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createAdminAccount_Click(object sender, EventArgs e)
        {
            frmRegister registerFrm = new frmRegister();
            registerFrm.isAdmin = true;
            registerFrm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            frmLogin loggedout = new frmLogin();
            loggedout.Show();
            this.Close();
        }
    }
}
