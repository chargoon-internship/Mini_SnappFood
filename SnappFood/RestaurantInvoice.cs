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
using Stimulsoft.Report;
using ViewModel;

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
            resInvoiceDataGridView.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
        }

        private void RestaurantInvoice_Load(object sender, EventArgs e)
        {
            if (user!.Customer != null)
            {
                bindCustomer();
            }
            else
            {
                bindRestaurant();
            }
           
        }

        void bindRestaurant()
        {
            resInvoiceDataGridView.DataSource = v.PrintRestaurantInvoices(user!.Id);
        }

        void bindCustomer()
        {
            resInvoiceDataGridView.DataSource = v.PrintCustomerInvoices(user!.Id);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resInvoiceDataGridView.CurrentRow != null)
            {
                ViewInvoiceService invoiceService=new ViewInvoiceService();
                int id = int.Parse(resInvoiceDataGridView.CurrentRow.Cells[0].Value.ToString()!);
                Invoice invoice=invoiceService.GetInvoiceById(id);
                string path = Directory.GetCurrentDirectory() + "/Report.mrt";
                StiReport stiReport=new StiReport();
                stiReport.Load(path);
                stiReport.Dictionary.Variables["Number"].Value = invoice.Number;
                stiReport.Dictionary.Variables["Time"].Value = invoice.Time.ToShamsi();
                stiReport.Dictionary.Variables["Description"].Value = invoice.Description;
                stiReport.Dictionary.Variables["Price"].Value = invoice.FinalPrice.ToString();
                stiReport.RegData("DT", invoiceService.MyTable(id));
                stiReport.Show();
            }
            else
            {
                MessageBox.Show("لطفا یک آیتم را انتخاب نمائید");
            }
        }
    }
}
