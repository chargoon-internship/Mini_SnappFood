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

namespace SnappFood
{
    public partial class FoodItem : UserControl
    {
        public FoodItem()
        {
            InitializeComponent();
        }
        public Food? MyFood { get; set; }
        private void addButton_Click(object sender, EventArgs e)
        {
            FoodPanel foodPanel=(FoodPanel)Application.OpenForms["FoodPanel"]!;
            bool exsit = foodPanel.Foods!.Any(n => n.Id == MyFood!.Id);
            if (exsit)
            {
                foodPanel.Foods!.Single(n => n.Id == MyFood!.Id).Quantity += 1;
            }
            else
            {
                MyFood!.Quantity += 1;
                foodPanel.Foods!.Add(MyFood);
            }
            counter.Text = MyFood!.Quantity.ToString();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            FoodPanel foodPanel = (FoodPanel)Application.OpenForms["FoodPanel"]!;
            if (MyFood!.Quantity > 0&&MyFood.Quantity<=1)
            {
                MyFood.Quantity -= 1;
                counter.Text = MyFood.Quantity.ToString();
                foodPanel.Foods!.Remove(MyFood);
            }
            if (MyFood.Quantity > 1)
            {
                counter.Text = (int.Parse(counter.Text)-1).ToString();
                foodPanel.Foods!.Single(n => n.Id == MyFood!.Id).Quantity -= 1;
            }
        }

        private void FoodItem_Load(object sender, EventArgs e)
        {
            foodName.Text = MyFood!.Name;
            lbl_price.Text=MyFood.Price.ToString();
            if (!MyFood.Exist)
            {
                lbl_exist.Visible = true;
            }
        }

    }
}
