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

        public RestaurantInvoice()
        {
            InitializeComponent();
            resInvoiceDataGridView.AutoGenerateColumns = false;
            resInvoiceDataGridView.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void RestaurantInvoice_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
            bind();

        }

        void bind()
        {
            resInvoiceDataGridView.DataSource = v.PrintRestaurantInvoices(user!.Id);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
