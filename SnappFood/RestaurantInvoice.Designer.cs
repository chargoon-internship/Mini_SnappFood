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
            resInvoiceDataGridView = new DataGridView();
            lblAmountsSum1 = new Label();
            lblAmountsSum2 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)resInvoiceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resInvoiceDataGridView
            // 
            resInvoiceDataGridView.AllowUserToAddRows = false;
            resInvoiceDataGridView.AllowUserToDeleteRows = false;
            resInvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resInvoiceDataGridView.Location = new Point(381, 23);
            resInvoiceDataGridView.Margin = new Padding(3, 4, 3, 4);
            resInvoiceDataGridView.Name = "resInvoiceDataGridView";
            resInvoiceDataGridView.ReadOnly = true;
            resInvoiceDataGridView.RowHeadersWidth = 51;
            resInvoiceDataGridView.RowTemplate.Height = 24;
            resInvoiceDataGridView.Size = new Size(539, 652);
            resInvoiceDataGridView.TabIndex = 0;
            // 
            // lblAmountsSum1
            // 
            lblAmountsSum1.AutoSize = true;
            lblAmountsSum1.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountsSum1.ForeColor = Color.White;
            lblAmountsSum1.Location = new Point(381, 679);
            lblAmountsSum1.Name = "lblAmountsSum1";
            lblAmountsSum1.Size = new Size(187, 33);
            lblAmountsSum1.TabIndex = 1;
            lblAmountsSum1.Text = "جمع مبالغ فاکتور ها : ";
            // 
            // lblAmountsSum2
            // 
            lblAmountsSum2.AutoSize = true;
            lblAmountsSum2.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountsSum2.ForeColor = Color.White;
            lblAmountsSum2.Location = new Point(603, 679);
            lblAmountsSum2.Name = "lblAmountsSum2";
            lblAmountsSum2.Size = new Size(71, 33);
            lblAmountsSum2.TabIndex = 2;
            lblAmountsSum2.Text = "label2";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(1012, 679);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(241, 39);
            btnBack.TabIndex = 3;
            btnBack.Text = "بازگشت به پنل رستوران";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RestaurantInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1382, 753);
            Controls.Add(btnBack);
            Controls.Add(lblAmountsSum2);
            Controls.Add(lblAmountsSum1);
            Controls.Add(resInvoiceDataGridView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RestaurantInvoice";
            Text = "فاکتورها";
            Load += RestaurantInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)resInvoiceDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView resInvoiceDataGridView;
        private Label lblAmountsSum1;
        private Label lblAmountsSum2;
        private Button btnBack;
    }
}