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
    public partial class EditProfile : Form
    {
        EditProfileService profile = new EditProfileService();
        public User user;

        bool isCustomer =true;
        public int UserId;
        public EditProfile()
        {
            //this.user = user;
            UserId = 2;
            InitializeComponent();

        }

        private void ShowInformation()
        {
            User user = profile.FindUserById(UserId);

            txtUserName.Text = user.UserName;
            txtPassWord.Text = user.Password;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            //if (user.Customer != null)

                if (isCustomer)
            {
                var Customer = profile.FindCustomer(UserId);
                txtNationalCode.Text = Customer.NatioalCode;
                txtAddress.Text = Customer.HomeAddress;

            }
            else
            {
                var restaurant = profile.FindRestaurant(UserId);
                txtNameRestaurant.Text = restaurant.NameOfRestaurant;
                txtAddress.Text = restaurant.Address;
                TimeBegin.Text = restaurant.BeginDate.ToString();
                TimeEnd.Text = restaurant.EndDate.ToString();
            }
        }
        private void ShowCustomerProfile()
        {
            lblCode.Visible = true;
            txtNationalCode.Visible = true;
            lblAddress.Text = "آدرس منزل";
            TimeBegin.Visible = false;
            TimeEnd.Visible = false;
            lbl_last.Visible = false;
            lblTime.Visible = false;
            lblNameRestaurant.Visible = false;
            txtNameRestaurant.Visible = false;
            btnExit.Location = new Point(216, 380);
            btnEdit.Location = new Point(41, 380);
        }
        private void ShowRestaurantProfile()
        {
            lblCode.Visible = false;
            txtNationalCode.Visible = false;
            lblAddress.Text = "آدرس رستوران";
            TimeBegin.Visible = true;
            TimeEnd.Visible = true;
            lbl_last.Visible = true;
            lblTime.Visible = true;
            lblNameRestaurant.Visible = true;
            txtNameRestaurant.Visible = true;

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassWord.Text;
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var address = txtAddress.Text;
            User user = new User
            {
                Id=UserId,
                UserName = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
            };
            //if (user.Customer != null)
            if(isCustomer)
            {
                var nationalCode = txtNationalCode.Text;
                user.Customer = new Customer
                {
                    Id=UserId,
                    HomeAddress = address,
                    NatioalCode = nationalCode
                };

            }
            else
            {
                var TmBegin = TimeBegin.Text;
                var TmEnd = TimeEnd.Text;
                var nameOfRestaurant = txtNameRestaurant.Text;
                user.Restaurant = new Restaurant
                {
                    Id = UserId,
                    Address = address,
                    BeginDate =TimeSpan.Parse(TmBegin),
                    EndDate = TimeSpan.Parse(TmEnd),
                    NameOfRestaurant=nameOfRestaurant
                };
            }
            var result = profile.UpdateProfile(user);

            if (result[0] != "موفقیت")
            {
                MessageBox.Show(result[0], "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(result[1], "اعلام", MessageBoxButtons.OK);
            }

        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            ShowInformation();
            //if (user.Customer != null)

             if (isCustomer)
                ShowCustomerProfile();
            else
                ShowRestaurantProfile();
        }

  
    }
}
