using BusinessLogicLayer.FoodService;
using DataAccessLayes;
using Entities;
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
        private void FoodPanel_Load(object sender, EventArgs e)
        {
            int top = 10;
            BuyFood buyFood = new BuyFood();
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
            Invoice invoice = new Invoice();

            cartItem.Customer = MyUser!.Customer;
            cartItem.RestaurantId = Restaurant_owner;
            MessageBox.Show(cartItem.GetPrice().ToString());
            //صفحه نمایش فاکتور از این نمایش داده می شود
        }

        private void brnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستنید که می خواهید از این صفحه خارج شوید با این کار تمام سبد خرید شما پاک می شود", "اخطار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MessageBox.Show("Clear");
                //کاربر به صفحه نمایش رستوران ها انتقال داده می شود
            }
        }
    }
}
