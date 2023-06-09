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
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnViewInvoices.Click += new System.EventHandler(this.btnViewInvoices_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(153, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "مشاهده پروفایل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RestaurantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewInvoices);
            this.Controls.Add(this.btnEditMenu);
            this.Controls.Add(this.btnRegisterMenu);
            this.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RestaurantPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنل رستوران";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegisterMenu;
        private Button btnEditMenu;
        private Button btnViewInvoices;
        private Button button1;
    }
}