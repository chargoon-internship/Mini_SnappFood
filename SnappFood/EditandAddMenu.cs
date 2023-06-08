using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.RestaurantService;

using Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace SnappFood
{
    public partial class EditandAddMenu : Form
    {
        EditMenuService menu = new EditMenuService();
        public bool isEdit { get; set; }
        public User user { get; set; }
        public EditandAddMenu(bool isEdit, User user)
        {
            InitializeComponent();

            this.isEdit = isEdit;
            this.user = user;
            if (isEdit)
            {
                ShowButtonForEdit();
            }
        }

        private void ShowButtonForEdit()
        {
            btnDeletMenu.Visible = true;
            btnEditMenu.Visible = true;
            btnSubmit.Visible = false;
            btnSubmit.Text = "ویرایش";
        }

        private void EditandAddMenu_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            var foods = menu.PrintAllMenu(user.Restaurant.Id);
            dgMenu.AutoGenerateColumns = false;
            dgMenu.DataSource = foods;
        }
        private void SetEmpty()
        {
            txtFood.Text = "";
            txtID.Text = "";
            txtPrice.Text = "";
            chBoxExistence.Checked = false;
        }


        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var name = txtFood.Text;
            var price = txtPrice.Text.Replace("ریال", "").Replace(",", "").Replace("\"", "").Trim();

            double.TryParse(price, out double priceOfFood);
            bool isExist = chBoxExistence.Checked;
            Food food;
            if (btnSubmit.Text == "ویرایش")
            {
                var IdOfFood = int.Parse(txtID.Text);
                List<string> result = new List<string>();

                food = new Food { Id = IdOfFood, Price = priceOfFood, Name = name, Restaurant_Id = user.Restaurant.Id, Exist = isExist };
                result = menu.UpdateMenu(food, user.Restaurant.Id);

                if (result[0] != "موفقیت")
                {
                    MessageBox.Show(result[0], "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateFood(IdOfFood);
                }
                else
                {
                    MessageBox.Show(result[1], "اعلام", MessageBoxButtons.OK);
                    ShowButtonForEdit();
                    SetEmpty();

                }
            }
            else
            {
                food = new Food { Price = priceOfFood, Name = name, Restaurant_Id = user.Restaurant.Id, Exist = isExist };
                string result = menu.AddMenu(food, isEdit, user.Restaurant.Id);
                if (result != "موفقیت")
                {
                    MessageBox.Show(result, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    SetEmpty();
                }
            }
            BindGrid();

        }
        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            if (dgMenu.CurrentRow != null)
            {
                int IdOfFood = (int)dgMenu.CurrentRow.Cells[0].Value;
                UpdateFood(IdOfFood);
                btnSubmit.Visible = true;
            }

            BindGrid();
        }

        private void UpdateFood(int IdOfFood)
        {
            var food = menu.FindMenuById(IdOfFood);
            txtPrice.Text = food.Price.ToString();
            txtFood.Text = food.Name.ToString();
            chBoxExistence.Checked = food.Exist;
            txtID.Text = IdOfFood.ToString();

        }
        private void btnDeletMenu_Click(object sender, EventArgs e)
        {
            if (dgMenu.CurrentRow != null)
            {
                int IdOfFood = (int)dgMenu.CurrentRow.Cells[0].Value;

                string name = dgMenu.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show($"اطمینان دارید؟ {name} ایا از حذف ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var result = menu.DeleteMenuById(IdOfFood);
                    MessageBox.Show(result, "اعلام", MessageBoxButtons.OK);

                }
                BindGrid();

            }

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
