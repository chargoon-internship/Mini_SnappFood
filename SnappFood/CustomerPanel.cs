using BusinessLogicLayer.CustomerService;
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
    public partial class CustomerPanel : Form
    {
        public User? user { get; set; }
        public int RestaurantId;

        List<Button> Buttons = new List<Button>();
        public CustomerPanel(User user)
        {
            this.user = user;
            InitializeComponent();

            UserNamelbl.Text = user.UserName + "عزیز خوش آمدید";

            CustomerPanelService customerPanel = new CustomerPanelService();
            List<string> buttonInfo = customerPanel.ShowRestaurantsData(Searchtxt.Text);

            foreach (string info in buttonInfo)
            {
                Button btn = new Button();
                btn.Width = 655;
                btn.Height = 300;
                btn.Name = String.Format(info);
                btn.Text = String.Format(info);
                btn.ForeColor = Color.White;
                btn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btn.BackgroundImage = SnappFood.Properties.Resources.rest_image;
                btn.Click += btn_Click!;
                Buttons.Add(btn);
                flowLayoutPanel1.Controls.Add(btn);
            }

        }
        private void btn_Click(object sender, EventArgs e)
        {
            CustomerPanelService customerPanel = new CustomerPanelService();
            Button pressedButton = (Button)sender;

            foreach (Button btn in Buttons)
            {
                if (pressedButton == btn)
                {
                    RestaurantId = customerPanel.GetRestaurantsIdByInfo(pressedButton.Text);
                }
            }
            FoodPanel foodpanel = new FoodPanel();
            foodpanel.Restaurant_owner = RestaurantId;
            foodpanel.MyUser = user;
            foodpanel.ShowDialog();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void Start(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RestaurantGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditProfileBtn_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(user!);
            editProfile.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            CustomerPanelService customerPanel = new CustomerPanelService();
            List<string> buttonInfo = customerPanel.ShowRestaurantsData(Searchtxt.Text);
            foreach (string info in buttonInfo)
            {
                Button btn = new Button();
                btn.Width = 450;
                btn.Height = 200;
                btn.Name = String.Format(info);
                btn.Text = String.Format(info);
                btn.ForeColor = Color.White;
                btn.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btn.BackgroundImage = SnappFood.Properties.Resources.rest_image;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}