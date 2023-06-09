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
using BusinessLogicLayer.CustomerService;
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
            btnDeleteAccount.Visible = true;
            txtNationalCode.Visible = false;
            btnExit.Visible = true;
            btnEdit.Visible = true;
            btnSubmit.Visible = false;
            lblCode.Visible = false;


        }
        private void ShowEditPage()
        {
            lblWelcome.Text = "ویرایش پروفایل";
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            txtAddress.Visible = true;
            lblAddress.Visible = true;
            btnExit.Visible = false;
            btnEdit.Visible = false;
            btnSubmit.Visible = true;
            btnDeleteAccount.Visible = false;

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


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            ShowEditPage();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            ShowInformation();
            ShowProfilePage();

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            /*            if (btnDeleteAccount.Text == "حذف حساب")
                        {
                            var id = user.Id;
                            user = new User();
                            string message = profile.DeleteUser(id);
                            MessageBox.Show(message, "", MessageBoxButtons.OK);
                        }*/
            if (user.Customer != null)
            {
                var res = (CustomerPanel)System.Windows.Forms.Application.OpenForms["CustomerPanel"]!;
                res.isExit = true;
            }
            else
            {
                var res = (RestaurantPanel)System.Windows.Forms.Application.OpenForms["RestaurantPanel"]!;
                res.isExit = true;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassWord.Text;
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var address = txtAddress.Text;
            User userUpdated = new User
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
                userUpdated.Customer = new Customer
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
                TimeSpan beginDate;
                TimeSpan endDate;
                TimeSpan.TryParse(TmBegin,out beginDate);
                TimeSpan.TryParse(TmEnd,out endDate);

                var nameOfRestaurant = txtNameRestaurant.Text;
                userUpdated.Restaurant = new Restaurant
                {
         
                    Id = user.Id,
                    Address = address,
                    BeginDate=beginDate,
                    EndDate=endDate,
                    NameOfRestaurant = nameOfRestaurant
                };
            }
            var result = profile.UpdateProfile(userUpdated);

            if (result[0] != "موفقیت")
            {
                MessageBox.Show(result[0], "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(result[1], "اعلام", MessageBoxButtons.OK);
                ShowProfilePage();
                user.FirstName = userUpdated.FirstName;
                user.LastName = userUpdated.LastName;
                user.UserName = userUpdated.UserName;
                user.Password = userUpdated.Password;
                if (user.Customer != null)
                {
                    user.Customer.NatioalCode = userUpdated.Customer.NatioalCode;
                    user.Customer.HomeAddress = userUpdated.Customer.HomeAddress;
                }
                else
                {
                    user.Restaurant.Address = userUpdated.Restaurant.Address;
                    user.Restaurant.NameOfRestaurant = userUpdated.Restaurant.NameOfRestaurant;
                    user.Restaurant.BeginDate = userUpdated.Restaurant.BeginDate;
                    user.Restaurant.EndDate = userUpdated.Restaurant.EndDate;
                }
            }
        }
    }
}
