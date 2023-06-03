﻿using DataAccessLayes;

namespace SnappFood
{
    public partial class RestaurantInvoice : Form
    {
        private readonly DB _db;

        public RestaurantInvoice()
        {
            InitializeComponent();
            _db = new DB();
        }

        private void RestaurantInvoice_Load(object sender, EventArgs e)
        {
            var orders = _db.GetOrders();
            resInvoiceDataGridView.DataSource = orders;

            var totalAmount = _db.GetOrders().Sum(o => o.FinalPrice);
            lblAmountsSum2.Text = totalAmount.ToString();

            resInvoiceDataGridView.Columns["Id"].Visible = false;

            resInvoiceDataGridView.Columns["Customer_Id"].Visible = false;
            resInvoiceDataGridView.Columns["CartItem_Id"].Visible = false;
            resInvoiceDataGridView.Columns["Restaurant_Id"].Visible = false;

            resInvoiceDataGridView.Columns["Customer"].Visible = false;
            resInvoiceDataGridView.Columns["CartItem"].Visible = false;
            resInvoiceDataGridView.Columns["Restaurant"].Visible = false;
        }

        private void lblAmountsSum1_Click(object sender, EventArgs e)
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
