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
            this.btnRegisterMenu = new System.Windows.Forms.Button();
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.btnViewInvoices = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterMenu
            // 
            this.btnRegisterMenu.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterMenu.Location = new System.Drawing.Point(522, 86);
            this.btnRegisterMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterMenu.Name = "btnRegisterMenu";
            this.btnRegisterMenu.Size = new System.Drawing.Size(314, 134);
            this.btnRegisterMenu.TabIndex = 0;
            this.btnRegisterMenu.Text = "ثبت منوی جدید";
            this.btnRegisterMenu.UseVisualStyleBackColor = true;
            this.btnRegisterMenu.Click += new System.EventHandler(this.btnRegisterMenu_Click);
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditMenu.Location = new System.Drawing.Point(522, 282);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(314, 127);
            this.btnEditMenu.TabIndex = 1;
            this.btnEditMenu.Text = "ویرایش منو";
            this.btnEditMenu.UseVisualStyleBackColor = true;
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditMenu_Click);
            // 
            // btnViewInvoices
            // 
            this.btnViewInvoices.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewInvoices.Location = new System.Drawing.Point(522, 462);
            this.btnViewInvoices.Name = "btnViewInvoices";
            this.btnViewInvoices.Size = new System.Drawing.Size(314, 117);
            this.btnViewInvoices.TabIndex = 2;
            this.btnViewInvoices.Text = "مشاهده فاکتورها";
            this.btnViewInvoices.UseVisualStyleBackColor = true;
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