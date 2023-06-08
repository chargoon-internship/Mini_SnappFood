using BusinessLogicLayer.InvoiceService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace SnappFood
{
    public partial class RestaurantInvoice : Form
    {
        ViewInvoiceService v = new ViewInvoiceService();
        public User? user { get; set; }

        public RestaurantInvoice(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void RestaurantInvoice_Load(object sender, EventArgs e)
        {
            var orders = v.PrintRestaurantInvoices(1);
            resInvoiceDataGridView.DataSource = orders;

            var totalAmount = v.PrintRestaurantInvoices(1).Sum(o => o.FinalPrice);
            lblAmountsSum2.Text = totalAmount.ToString();

            resInvoiceDataGridView.Columns["Id"].Visible = false;
            resInvoiceDataGridView.Columns["Customer_Id"].Visible = false;
            resInvoiceDataGridView.Columns["Restaurant_Id"].Visible = false;
            resInvoiceDataGridView.Columns["Restaurant"].Visible = false;
            resInvoiceDataGridView.Columns["Customer"].Visible = false;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            RestaurantPanel f = new RestaurantPanel(user);
            f.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void resInvoiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAmountsSum2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
