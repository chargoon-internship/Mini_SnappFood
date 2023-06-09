﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessLogicLayer.SignUpAndLoginService;
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
            Clear();
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
                SignUpService signUpService = new SignUpService();
                string result=signUpService.SignUp(user);
                MessageBox.Show(result);
                if(result== "ثبت نام شما با موفقیت انجام شد")
                {
                    HideCustomerRegister(false);
                    HideLoginPage(true);
                    Clear();
                }
            }
            else
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.UserName = txt_userLogin.Text;
                user.Password = txt_userPass.Text;
                TimeSpan start;
                TimeSpan end;
                TimeSpan.TryParse(TimeBegin.Text, out start);
                TimeSpan.TryParse(TimeEnd.Text,out end);
                user.Restaurant = new Restaurant()
                {
                    Id = user.Id,
                    NameOfRestaurant = txtCode.Text,
                    Address = txtAddress.Text,
                    BeginDate=start,
                    EndDate=end
                };
                SignUpService signUpService = new SignUpService();
                string result = signUpService.SignUp(user);
                MessageBox.Show(result);
                if (result == "ثبت نام شما با موفقیت انجام شد")
                {
                    lblCode.Text = "کد ملی";
                    HideCustomerRegister(false);
                    HideLoginPage(true);
                    Clear();
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            (string Message, bool isCustomer,bool enter) = loginService.Execute(txt_userLogin.Text, txt_userPass.Text);

            MessageBox.Show(Message);
            if (enter)
            {
                if (isCustomer)
                {
                    User user = loginService.GetUser(txt_userLogin.Text);
                    CustomerPanel customerPanel = new CustomerPanel(user);
                    customerPanel.user = user;
                    this.Hide();
                    customerPanel.ShowDialog();
                    this.Close();

                }
                else
                {
                    User user = loginService.GetUser(txt_userLogin.Text);
                    RestaurantPanel restaurantPanel = new RestaurantPanel(user);
                    restaurantPanel.user = user;
                    this.Hide();
                    restaurantPanel.ShowDialog();
                    this.Close();
                }
            }

        }
    }
}