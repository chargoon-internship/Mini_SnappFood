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
        public bool isEdit { get; set; }
        public User user { get; set; }
        public EditandAddMenu()
        {
            InitializeComponent();
            if (isEdit)
            {
                btnDeletMenu.Visible = true;
                btnEditMenu.Visible = true;
            }
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
                food = new Food { Id = int.Parse(txtID.Text), Price = priceOfFood, Name = name, Restaurant_Id = 2, CartItem_Id = 2, Exist = isExist };
                var result = menu.UpdateMenu(food);


                MessageBox.Show(result, "اعلام", MessageBoxButtons.OK);


            }
            else
            {
                food = new Food { Price = priceOfFood, Name = name, Restaurant_Id = 2, CartItem_Id = 2, Exist = isExist };

                menu.AddMenu(food);
            }
            BindGrid();
            SetEmpty();
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
                txtID.Text = IdOfFood.ToString();

                btnSubmit.Text = "ویرایش";

            }

            BindGrid();
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
