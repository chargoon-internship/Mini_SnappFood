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
        public User? MyUser { get; set; }
        public CustomerPanel()
        {
            InitializeComponent();
            CustomerPanelService customerPanel = new CustomerPanelService();
            List<Restaurant> restaurants = customerPanel.GetRestaurants();
            List<string> buttonInfo = customerPanel.RestaurantShowData();

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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RestaurantGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
