namespace SnappFood
{
    partial class RestaurantPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegisterMenu = new Button();
            btnEditMenu = new Button();
            btnViewInvoices = new Button();
            btnViewProfile = new Button();
            SuspendLayout();
            // 
            // btnRegisterMenu
            // 
            btnRegisterMenu.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterMenu.Location = new Point(522, 86);
            btnRegisterMenu.Margin = new Padding(3, 4, 3, 4);
            btnRegisterMenu.Name = "btnRegisterMenu";
            btnRegisterMenu.Size = new Size(314, 134);
            btnRegisterMenu.TabIndex = 0;
            btnRegisterMenu.Text = "ثبت منوی جدید";
            btnRegisterMenu.UseVisualStyleBackColor = true;
            btnRegisterMenu.Click += btnRegisterMenu_Click;
            // 
            // btnEditMenu
            // 
            btnEditMenu.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditMenu.Location = new Point(522, 282);
            btnEditMenu.Name = "btnEditMenu";
            btnEditMenu.Size = new Size(314, 127);
            btnEditMenu.TabIndex = 1;
            btnEditMenu.Text = "ویرایش منو";
            btnEditMenu.UseVisualStyleBackColor = true;
            btnEditMenu.Click += btnEditMenu_Click;
            // 
            // btnViewInvoices
            // 
            btnViewInvoices.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewInvoices.Location = new Point(522, 462);
            btnViewInvoices.Name = "btnViewInvoices";
            btnViewInvoices.Size = new Size(314, 117);
            btnViewInvoices.TabIndex = 2;
            btnViewInvoices.Text = "مشاهده فاکتورها";
            btnViewInvoices.UseVisualStyleBackColor = true;
            btnViewInvoices.Click += btnViewInvoices_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.Font = new Font("IRANSansWeb(FaNum)", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewProfile.Location = new Point(12, 12);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.RightToLeft = RightToLeft.Yes;
            btnViewProfile.Size = new Size(153, 45);
            btnViewProfile.TabIndex = 3;
            btnViewProfile.Text = "مشاهده پروفایل";
            btnViewProfile.UseVisualStyleBackColor = true;
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // RestaurantPanel
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1370, 749);
            Controls.Add(btnViewProfile);
            Controls.Add(btnViewInvoices);
            Controls.Add(btnEditMenu);
            Controls.Add(btnRegisterMenu);
            Font = new Font("IRANSansWeb(FaNum)", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RestaurantPanel";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پنل رستوران";
            Load += RestaurantPanel_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisterMenu;
        private Button btnEditMenu;
        private Button btnViewInvoices;
        private Button btnViewProfile;
    }
}