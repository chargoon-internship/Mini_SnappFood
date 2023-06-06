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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            HideLoginPage(false);
            HideRegisterButton(true);
        }

        void HideLoginPage(bool show, int a = 0)
        {
            UserLogin.Visible = show;
            PassLogin.Visible = show;
            txt_userLogin.Visible = show;
            txt_userPass.Visible = show;
            if (a == 0)
            {
                buttonSignUp.Visible = show;
                buttonLogin.Visible = show;
            }
            else
            {
                buttonSignUp.Visible = false;
                buttonLogin.Visible = false;
            }

        }

        void HideRegisterButton(bool show)
        {
            buttonRestaurant.Visible = show;
            buttonCustomer.Visible = show;
            btnBack.Visible = show;
        }

        void HideCustomerRegister(bool show, int a = 0)
        {
            lblFirstName.Visible = show;
            txtFirstName.Visible = show;
            lblLastName.Visible = show;
            txtLastName.Visible = show;
            lblCode.Visible = show;
            txtCode.Visible = show;
            lblAddress.Visible = show;
            txtAddress.Visible = show;
            buttonSubmit.Visible = show;
            buttonGoBack.Visible = show;
            if (a == 0)
            {
                lblTime.Visible = false;
                TimeBegin.Visible = false;
                TimeEnd.Visible = false;
                lbl_last.Visible = false;
            }
            else
            {
                lblTime.Visible = true;
                TimeBegin.Visible = true;
                TimeEnd.Visible = true;
                lbl_last.Visible = true;
            }
        }

        void HideRestaurantRegister(bool show)
        {
            HideCustomerRegister(show, 1);
            lblCode.Text = "نام رستوران";
        }

        void Clear()
        {
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    ((TextBox)item).Clear();
                }

            }
            TimeBegin.Text= string.Empty;
            TimeEnd.Text= string.Empty;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            HideCustomerRegister(false);
            HideRegisterButton(false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HideLoginPage(true);
            HideRegisterButton(false);
        }


        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            HideCustomerRegister(true);
            HideLoginPage(true, 1);
            HideRegisterButton(false);
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            HideCustomerRegister(false);
            HideLoginPage(true);
            lblCode.Text = "کد ملی";
            Clear();
        }

        private void buttonRestaurant_Click(object sender, EventArgs e)
        {
            HideRestaurantRegister(true);
            HideLoginPage(true, 1);
            HideRegisterButton(false);
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            User? user = new User();
            if (TimeBegin.Visible == false)
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.UserName = txt_userLogin.Text;
                user.Password = txt_userPass.Text;
                user.Customer = new Customer()
                {
                    Id = user.Id,
                    NatioalCode = txtCode.Text,
                    HomeAddress = txtAddress.Text,

                };
                UserCrud db=new UserCrud();
                if (db.Create(user))
                {
                    MessageBox.Show("ثبت نام شما با موفقیت انجام شد");
                    Clear();
                }
                else
                {
                    MessageBox.Show("مشکلی پیش آمده است");
                }
            }
            else
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.UserName = txt_userLogin.Text;
                user.Password = txt_userPass.Text;
                user.Restaurant = new Restaurant()
                {
                    Id = user.Id,
                    NameOfRestaurant = txtCode.Text,
                    Address = txtAddress.Text,
                    BeginDate=TimeSpan.Parse(TimeBegin.Text),
                    EndDate=TimeSpan.Parse(TimeEnd.Text)
                };
                UserCrud db = new UserCrud();
                if (db.Create(user))
                {
                    MessageBox.Show("ثبت نام شما با موفقیت انجام شد");
                    Clear();
                }
                else
                {
                    MessageBox.Show("مشکلی پیش آمده است");
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txt_userLogin.Text != "" && txt_userPass.Text != "")
            {
                UserCrud db =new UserCrud();
                if (db.Login(txt_userLogin.Text, txt_userPass.Text))
                {
                    MessageBox.Show("شما با موفقیت وارد شددید");
                    User myUser=db.GetUser(txt_userLogin.Text);
                    if (myUser.Customer != null)
                    {
                        //صفحه مربوط به مشتری باز شود
                    }
                    else if(myUser.Restaurant!= null)
                    {
                        //صفحه مربوط به صاحب رستوران باز شود
                    }
                }
                else
                {
                    MessageBox.Show("نام کاربری و رمز عبور وارد شده، اشتباه است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("لطفا فیلد های خالی را پر نمائید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
