﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace buBilet
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void register_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin sform = new frmLogin();
            sform.Show();
            this.Hide();
        }

        private void xRegister_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
