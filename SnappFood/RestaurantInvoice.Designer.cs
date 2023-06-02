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
            ((System.ComponentModel.ISupportInitialize)(this.resInvoiceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resInvoiceDataGridView
            // 
            this.resInvoiceDataGridView.AllowUserToAddRows = false;
            this.resInvoiceDataGridView.AllowUserToDeleteRows = false;
            this.resInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resInvoiceDataGridView.Location = new System.Drawing.Point(106, 59);
            this.resInvoiceDataGridView.Name = "resInvoiceDataGridView";
            this.resInvoiceDataGridView.ReadOnly = true;
            this.resInvoiceDataGridView.RowHeadersWidth = 51;
            this.resInvoiceDataGridView.RowTemplate.Height = 24;
            this.resInvoiceDataGridView.Size = new System.Drawing.Size(1189, 558);
            this.resInvoiceDataGridView.TabIndex = 0;
            // 
            // lblAmountsSum1
            // 
            this.lblAmountsSum1.AutoSize = true;
            this.lblAmountsSum1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAmountsSum1.Location = new System.Drawing.Point(100, 649);
            this.lblAmountsSum1.Name = "lblAmountsSum1";
            this.lblAmountsSum1.Size = new System.Drawing.Size(187, 33);
            this.lblAmountsSum1.TabIndex = 1;
            this.lblAmountsSum1.Text = "جمع مبالغ فاکتور ها : ";
            // 
            // lblAmountsSum2
            // 
            this.lblAmountsSum2.AutoSize = true;
            this.lblAmountsSum2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAmountsSum2.Location = new System.Drawing.Point(333, 649);
            this.lblAmountsSum2.Name = "lblAmountsSum2";
            this.lblAmountsSum2.Size = new System.Drawing.Size(71, 33);
            this.lblAmountsSum2.TabIndex = 2;
            this.lblAmountsSum2.Text = "label2";
            // 
            // RestaurantInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.lblAmountsSum2);
            this.Controls.Add(this.lblAmountsSum1);
            this.Controls.Add(this.resInvoiceDataGridView);
            this.Name = "RestaurantInvoice";
            this.Text = "RestaurantInvoice";
            this.Load += new System.EventHandler(this.RestaurantInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resInvoiceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resInvoiceDataGridView;
        private System.Windows.Forms.Label lblAmountsSum1;
        private System.Windows.Forms.Label lblAmountsSum2;
    }
}