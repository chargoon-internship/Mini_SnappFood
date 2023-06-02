using DataAccessLayes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayes;

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
    }
}
