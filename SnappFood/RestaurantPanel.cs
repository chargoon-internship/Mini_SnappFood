﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnappFood
{
    public partial class RestaurantPanel : Form
    {
        public RestaurantPanel()
        {
            InitializeComponent();
        }

        private void RestaurantPanel_Load(object sender, EventArgs e)
        {

        }

        private void ViewInvoices_Click(object sender, EventArgs e)
        {
            RestaurantInvoice f = new RestaurantInvoice();
            f.FormClosed += (s, args) => this.Close();
            f.Show();
            this.Hide();
        }
    }
}
