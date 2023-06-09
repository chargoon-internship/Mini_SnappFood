using BusinessLogicLayer.FoodService;
using DataAccessLayes;
using Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel.CartItem;

namespace SnappFood
{
    public partial class FoodPanel : Form
    {

        public FoodPanel()
        {
            InitializeComponent();
        }
        public User? MyUser { get; set; }
        public int Restaurant_owner { get; set; }
        public List<Food>? Foods { get; set; } = new List<Food>();

        public bool isBtn=false;

        private void FoodPanel_Load(object sender, EventArgs e)
        {
            int top = 10;
            BuyFoodService buyFood = new BuyFoodService();
            foreach (var item in buyFood.GetFoods(Restaurant_owner))
            {
                panel1.Controls.Add(new FoodItem() { Width = 1335, Height = 120, Top = top, MyFood = item });
                top += 100;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CartItemViewModel cartItem = new CartItemViewModel();
            cartItem.Foods = Foods;
            cartItem.CustomerId = MyUser.Id;
            cartItem.RestaurantId = Restaurant_owner;
            if (cartItem.Foods!.Count > 0)
            {
                CustomerInvoice customerInvoice = new CustomerInvoice();
                customerInvoice.CartItem = cartItem;
                customerInvoice.user = MyUser;
                customerInvoice.ShowDialog();
            }
            else
            {
                MessageBox.Show("شما آیتمی را برای سفارش اضافه نکردید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isBtn == false)
            {
                if (MessageBox.Show("آیا مطمئن هستنید که می خواهید از این صفحه خارج شوید با این کار تمام سبد خرید شما پاک می شود", "اخطار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    base.OnFormClosing(e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                base.OnFormClosing(e);
            }

           
        }

        private void brnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستنید که می خواهید از این صفحه خارج شوید با این کار تمام سبد خرید شما پاک می شود", "اخطار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                isBtn= true;
                this.Close();
            }
        }
    }
}
