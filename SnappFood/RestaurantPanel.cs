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
        public User? user { get; set; }

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
            RestaurantInvoice newForm = new RestaurantInvoice(user);
            newForm.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(user);
            editProfile.ShowDialog();

        }

        private void RestaurantPanel_Load_1(object sender, EventArgs e)
        {

        }
    }
}
