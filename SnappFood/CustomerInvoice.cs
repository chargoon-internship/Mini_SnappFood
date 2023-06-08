using BusinessLogicLayer.InvoiceService;
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
using Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ViewModel.CartItem;
using BusinessLogicLayer.FoodService;
using static System.Net.Mime.MediaTypeNames;

namespace SnappFood
{
    public partial class CustomerInvoice : Form
    {
        ViewInvoiceService v = new ViewInvoiceService();
        public User? user { get; set; }

       public CartItemViewModel? CartItem { get; set; }

        public CustomerInvoice()
        {
            InitializeComponent();
            userInvoiceDataGridView.AutoGenerateColumns = false;
            userInvoiceDataGridView.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void CustomerInvoice_Load_1(object sender, EventArgs e)
        {
            lblSum.Text = CartItem!.GetPrice().ToString();
            userInvoiceDataGridView.DataSource = CartItem.Foods;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice()
            {
                Customer_Id = CartItem!.CustomerId,
                Restaurant_Id = CartItem!.RestaurantId,
                Description = richTextBox1.Text,
                FinalPrice = CartItem.GetPrice(),
                Time = DateTime.Now
            };
            BuyFoodService buyFoodService=new BuyFoodService();
            if (buyFoodService.Create(invoice, CartItem.Foods!))
            {
                MessageBox.Show("سفارش شما با موفقیت ثبت شد");
                this.Close();
                FoodPanel res = (FoodPanel)System.Windows.Forms.Application.OpenForms["FoodPanel"]!;
                res.isBtn=true;
                res.Close(); 
            }
            else
            {
                MessageBox.Show("مشکلی در ثبت سفارش شما پیش آماده است");
            }
        }
    }
}
