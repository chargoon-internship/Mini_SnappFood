﻿using System;
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
    public partial class EditProfile : Form
    {
        EditProfileService profile = new EditProfileService();
        public User user;


        public EditProfile(User user)
        {
            this.user = user;
            InitializeComponent();

        }
        private void ShowProfilePage()
        {
            lblWelcome.Text = "مشاهده پروفایل";
            btnDeleteAccount.Text = "خروج از حساب";
            btnEdit.Text = "ویرایش اطلاعات";
            btnExit.Text = "بازگشت";
            btnDeleteAccount.Location = new Point(131, 250);
            btnEdit.Location = new Point(24, 250);
            btnExit.Location = new Point(239, 250);
            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            txtAddress.Visible = false;
            lblAddress.Visible = false;
            TimeBegin.Visible = false;
            TimeEnd.Visible = false;
            lbl_last.Visible = false;
            lblTime.Visible = false;
            lblNameRestaurant.Visible = false;
            txtNameRestaurant.Visible = false;
            txtNationalCode.Visible = false;


        }
        private void ShowEditPage()
        {
            lblWelcome.Text = "ویرایش پروفایل";
            btnDeleteAccount.Text = "حذف حساب";
            btnEdit.Text = "ثبت اطلاعات";
            btnExit.Text = "بازگشت به حساب";
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            txtAddress.Visible = true;
            lblAddress.Visible = true;

            if (user.Customer != null)
                ShowCustomerProfile();
            else
                ShowRestaurantProfile();

        }
        private void ShowInformation()
        {

            txtUserName.Text = user.UserName;
            txtPassWord.Text = user.Password;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            if (user.Customer != null)
            {

                txtNationalCode.Text = user.Customer.NatioalCode;
                txtAddress.Text = user.Customer.HomeAddress;

            }
            else
            {

                txtNameRestaurant.Text = user.Restaurant.NameOfRestaurant;
                txtAddress.Text = user.Restaurant.Address;
                TimeBegin.Text = user.Restaurant.BeginDate.ToString();
                TimeEnd.Text = user.Restaurant.EndDate.ToString();
            }
        }
        private void ShowCustomerProfile()
        {
            lblCode.Visible = true;
            txtNationalCode.Visible = true;
            TimeBegin.Visible = false;
            TimeEnd.Visible = false;
            lbl_last.Visible = false;
            lblTime.Visible = false;
            lblNameRestaurant.Visible = false;
            txtNameRestaurant.Visible = false;
            btnExit.Location = new Point(239, 380);
            btnEdit.Location = new Point(24, 380);
            btnDeleteAccount.Location = new Point(131, 380);
        }
        private void ShowRestaurantProfile()
        {
            lblCode.Visible = false;
            txtNationalCode.Visible = false;
            TimeBegin.Visible = true;
            TimeEnd.Visible = true;
            lbl_last.Visible = true;
            lblTime.Visible = true;
            lblNameRestaurant.Visible = true;
            txtNameRestaurant.Visible = true;
            btnDeleteAccount.Location = new Point(131, 407);
            btnEdit.Location = new Point(24, 407);
            btnExit.Location = new Point(239, 407);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "ویرایش اطلاعات")
            {
                ShowEditPage();
            }
            else
            {
                var username = txtUserName.Text;
                var password = txtPassWord.Text;
                var firstName = txtFirstName.Text;
                var lastName = txtLastName.Text;
                var address = txtAddress.Text;
                User user1 = new User
                {
                    Id = user.Id,
                    UserName = username,
                    Password = password,
                    FirstName = firstName,
                    LastName = lastName,
                };
                if (user.Customer != null)
                {
                    var nationalCode = txtNationalCode.Text;
                    user1.Customer = new Customer
                    {
                        Id = user.Id,
                        HomeAddress = address,
                        NatioalCode = nationalCode
                    };

                }
                else
                {
                    var TmBegin = TimeBegin.Text;
                    var TmEnd = TimeEnd.Text;
                    var nameOfRestaurant = txtNameRestaurant.Text;
                    user1.Restaurant = new Restaurant
                    {
                        Id = user.Id,
                        Address = address,
                        BeginDate = TimeSpan.Parse(TmBegin),
                        EndDate = TimeSpan.Parse(TmEnd),
                        NameOfRestaurant = nameOfRestaurant
                    };
                }
                var result = profile.UpdateProfile(user1);

                if (result[0] != "موفقیت")
                {
                    MessageBox.Show(result[0], "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(result[1], "اعلام", MessageBoxButtons.OK);
                    ShowProfilePage();
                }

            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            ShowInformation();
            ShowProfilePage();

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (btnDeleteAccount.Text == "حذف حساب")
            {
                string message = profile.DeleteUser(user.Id);
                MessageBox.Show(message, "", MessageBoxButtons.OK);
            }
            Application.Restart();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "بازگشت به حساب")
                ShowProfilePage();
            else
                this.Close();

        }
    }
}
