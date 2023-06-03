using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using Entities;

namespace SnappFood
{
    public partial class EditandAddMenu : Form
    {
        EditMenu menu = new EditMenu();
        public EditandAddMenu()
        {
            InitializeComponent();
        }

        private void EditandAddMenu_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            var foods = menu.PrintAllMenu(2);
            dgMenu.AutoGenerateColumns = false;
            dgMenu.DataSource = foods;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var name = txtFood.Text;
            var price = txtPrice.Text.Replace("ریال", "").Replace(",", "").Replace("\"", "").Trim();
            double.TryParse(price, out double priceOfFood);
            bool isExist = chBoxExistence.Checked;
            var food = new Food { Price = priceOfFood, Name = name, Restaurant_Id = 2, CartItem_Id = 2, Exist = isExist };
            if (btnSubmit.Text == "ویرایش")
            {
                var food1 = new Food { Id = (int)dgMenu.CurrentRow.Cells[0].Value, Price = priceOfFood, Name = name, Restaurant_Id = 2, CartItem_Id = 2, Exist = isExist };

                menu.UpdateMenu(food1);
            }
            else
            {
                menu.AddMenu(food);
            }
            BindGrid();
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            if (dgMenu.CurrentRow != null)
            {
                int IdOfFood = (int)dgMenu.CurrentRow.Cells[0].Value;

                var food = menu.FindMenuById(IdOfFood);
                txtPrice.Text = food.Price.ToString();
                txtFood.Text = food.Name.ToString();
                chBoxExistence.Checked = food.Exist;

                btnSubmit.Text = "ویرایش";

            }

            BindGrid();
        }

        private void btnDeletMenu_Click(object sender, EventArgs e)
        {
            if (dgMenu.CurrentRow != null)
            {
                /* int numberOfInvoice = (int)dgShowResult.CurrentRow.Cells[0].Value;
                 string name = dgShowResult.CurrentRow.Cells[2].Value.ToString();
                 if (MessageBox.Show($"Are u sure to delete {name}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 {
                     var result = createMenu.Delete(numberOfInvoice);
                     if (!result)
                     {
                         MessageBox.Show("فاکتور مورد نظر حذف نشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }*/
                BindGrid();

            }

        }
    }
}
