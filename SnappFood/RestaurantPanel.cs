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
        public RestaurantPanel()
        {
            //this.user=_user
            InitializeComponent();
        }

        private void RestaurantPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterMenu_Click(object sender, EventArgs e)
        {
            EditandAddMenu newForm = new EditandAddMenu(false);

            newForm.ShowDialog();
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            EditandAddMenu newForm = new EditandAddMenu(true);
            newForm.isEdit = true;
            newForm.ShowDialog();
        }

        private void btnViewInvoices_Click(object sender, EventArgs e)
        {
            RestaurantInvoice newForm = new RestaurantInvoice();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }
    }
}
