namespace SnappFood
{
    partial class RestaurantInvoice
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
            this.resInvoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.lblAmountsSum1 = new System.Windows.Forms.Label();
            this.lblAmountsSum2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.resInvoiceDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resInvoiceDataGridView
            // 
            this.resInvoiceDataGridView.AllowUserToAddRows = false;
            this.resInvoiceDataGridView.AllowUserToDeleteRows = false;
            this.resInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resInvoiceDataGridView.Location = new System.Drawing.Point(53, 41);
            this.resInvoiceDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resInvoiceDataGridView.Name = "resInvoiceDataGridView";
            this.resInvoiceDataGridView.ReadOnly = true;
            this.resInvoiceDataGridView.RowHeadersWidth = 51;
            this.resInvoiceDataGridView.RowTemplate.Height = 24;
            this.resInvoiceDataGridView.Size = new System.Drawing.Size(540, 472);
            this.resInvoiceDataGridView.TabIndex = 0;
            // 
            // lblAmountsSum1
            // 
            this.lblAmountsSum1.AutoSize = true;
            this.lblAmountsSum1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountsSum1.ForeColor = System.Drawing.Color.White;
            this.lblAmountsSum1.Location = new System.Drawing.Point(53, 517);
            this.lblAmountsSum1.Name = "lblAmountsSum1";
            this.lblAmountsSum1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmountsSum1.Size = new System.Drawing.Size(187, 33);
            this.lblAmountsSum1.TabIndex = 1;
            this.lblAmountsSum1.Text = "جمع مبالغ فاکتور ها : ";
            // 
            // lblAmountsSum2
            // 
            this.lblAmountsSum2.AutoSize = true;
            this.lblAmountsSum2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountsSum2.ForeColor = System.Drawing.Color.White;
            this.lblAmountsSum2.Location = new System.Drawing.Point(246, 517);
            this.lblAmountsSum2.Name = "lblAmountsSum2";
            this.lblAmountsSum2.Size = new System.Drawing.Size(71, 33);
            this.lblAmountsSum2.TabIndex = 2;
            this.lblAmountsSum2.Text = "label2";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(829, 602);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(241, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "بازگشت به پنل رستوران";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resInvoiceDataGridView);
            this.groupBox1.Controls.Add(this.lblAmountsSum1);
            this.groupBox1.Controls.Add(this.lblAmountsSum2);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(227, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 569);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سفارشات";
            // 
            // RestaurantInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RestaurantInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاکتورها";
            ((System.ComponentModel.ISupportInitialize)(this.resInvoiceDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView resInvoiceDataGridView;
        private Label lblAmountsSum1;
        private Label lblAmountsSum2;
        private Button btnBack;
        private GroupBox groupBox1;
    }
}