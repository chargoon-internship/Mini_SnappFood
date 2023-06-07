﻿using BusinessLogicLayer.InvoiceService;
using DataAccessLayes.Services;
using System;
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
    public partial class CustomerInvoice : Form
    {
        ViewInvoiceService v = new ViewInvoiceService();

        public CustomerInvoice()
        {
            InitializeComponent();
        }

        private void CustomerInvoice_Load(object sender, EventArgs e)
        {
            var orders = v.PrintCustomerInvoices(1);
            userInvoiceDataGridView.DataSource = orders;

            var totalAmount = v.PrintCustomerInvoices(1).Sum(o => o.FinalPrice);
            lblSum.Text = totalAmount.ToString();

            userInvoiceDataGridView.Columns["Id"].Visible = false;
            userInvoiceDataGridView.Columns["Customer_Id"].Visible = false;
            userInvoiceDataGridView.Columns["Restaurant_Id"].Visible = false;
            userInvoiceDataGridView.Columns["Restaurant"].Visible = false;
            userInvoiceDataGridView.Columns["Customer"].Visible = false;
            userInvoiceDataGridView.Columns["Time"].Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RestaurantPanel f = new RestaurantPanel();
            f.FormClosed += (s, args) => this.Close();
            f.Show();
            this.Hide();
        }
    }
}
