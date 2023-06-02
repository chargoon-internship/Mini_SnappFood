namespace SnappTest
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
            this.RegisterMenu = new System.Windows.Forms.Button();
            this.EditMenu = new System.Windows.Forms.Button();
            this.ViewInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterMenu
            // 
            this.RegisterMenu.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegisterMenu.Location = new System.Drawing.Point(522, 86);
            this.RegisterMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterMenu.Name = "RegisterMenu";
            this.RegisterMenu.Size = new System.Drawing.Size(314, 134);
            this.RegisterMenu.TabIndex = 0;
            this.RegisterMenu.Text = "ثبت منوی جدید";
            this.RegisterMenu.UseVisualStyleBackColor = true;
            // 
            // EditMenu
            // 
            this.EditMenu.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EditMenu.Location = new System.Drawing.Point(522, 282);
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(314, 127);
            this.EditMenu.TabIndex = 1;
            this.EditMenu.Text = "ویرایش منو";
            this.EditMenu.UseVisualStyleBackColor = true;
            // 
            // ViewInvoices
            // 
            this.ViewInvoices.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ViewInvoices.Location = new System.Drawing.Point(522, 462);
            this.ViewInvoices.Name = "ViewInvoices";
            this.ViewInvoices.Size = new System.Drawing.Size(314, 117);
            this.ViewInvoices.TabIndex = 2;
            this.ViewInvoices.Text = "مشاهده فاکتورها";
            this.ViewInvoices.UseVisualStyleBackColor = true;
            this.ViewInvoices.Click += new System.EventHandler(this.ViewInvoices_Click);
            // 
            // RestaurantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.ViewInvoices);
            this.Controls.Add(this.EditMenu);
            this.Controls.Add(this.RegisterMenu);
            this.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RestaurantPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantPanel";
            this.Load += new System.EventHandler(this.RestaurantPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterMenu;
        private System.Windows.Forms.Button EditMenu;
        private System.Windows.Forms.Button ViewInvoices;
    }
}