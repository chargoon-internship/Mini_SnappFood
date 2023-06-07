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
            var orders = v.PrintCustomerInvoices(2);
            userInvoiceDataGridView.DataSource = orders;

            var totalAmount = v.PrintCustomerInvoices(2).Sum(o => o.FinalPrice);
            lblSum.Text = totalAmount.ToString();

            userInvoiceDataGridView.Columns["Id"].Visible = false;
            userInvoiceDataGridView.Columns["Customer_Id"].Visible = false;
            userInvoiceDataGridView.Columns["Restaurant_Id"].Visible = false;
            userInvoiceDataGridView.Columns["Restaurant"].Visible = false;
            userInvoiceDataGridView.Columns["Customer"].Visible = false;

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
    }
}
