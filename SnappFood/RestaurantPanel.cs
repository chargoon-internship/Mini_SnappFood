using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace SnappFood
{
    public partial class RestaurantPanel : Form
    {
        public User user { get; set; }
        public RestaurantPanel(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void RestaurantPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterMenu_Click(object sender, EventArgs e)
        {
            EditandAddMenu addMenu = new EditandAddMenu(false, user);
            addMenu.ShowDialog();
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            EditandAddMenu editMenu = new EditandAddMenu(true, user);
            editMenu.ShowDialog();
        }

        private void btnViewInvoices_Click(object sender, EventArgs e)
        {
            RestaurantInvoice Invoice = new RestaurantInvoice(user);
            Invoice.ShowDialog();
/*            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();*/
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(user);
            editProfile.ShowDialog();
            
        }
    }
}
