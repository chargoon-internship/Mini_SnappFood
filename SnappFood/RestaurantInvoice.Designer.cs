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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)resInvoiceDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // resInvoiceDataGridView
            // 
            resInvoiceDataGridView.AllowUserToAddRows = false;
            resInvoiceDataGridView.AllowUserToDeleteRows = false;
            resInvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resInvoiceDataGridView.Location = new Point(53, 41);
            resInvoiceDataGridView.Margin = new Padding(3, 4, 3, 4);
            resInvoiceDataGridView.Name = "resInvoiceDataGridView";
            resInvoiceDataGridView.ReadOnly = true;
            resInvoiceDataGridView.RowHeadersWidth = 51;
            resInvoiceDataGridView.RowTemplate.Height = 24;
            resInvoiceDataGridView.Size = new Size(540, 472);
            resInvoiceDataGridView.TabIndex = 0;
            resInvoiceDataGridView.CellContentClick += resInvoiceDataGridView_CellContentClick;
            // 
            // lblAmountsSum1
            // 
            lblAmountsSum1.AutoSize = true;
            lblAmountsSum1.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountsSum1.ForeColor = Color.White;
            lblAmountsSum1.Location = new Point(53, 517);
            lblAmountsSum1.Name = "lblAmountsSum1";
            lblAmountsSum1.RightToLeft = RightToLeft.No;
            lblAmountsSum1.Size = new Size(187, 33);
            lblAmountsSum1.TabIndex = 1;
            lblAmountsSum1.Text = "جمع مبالغ فاکتور ها : ";
            // 
            // lblAmountsSum2
            // 
            lblAmountsSum2.AutoSize = true;
            lblAmountsSum2.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountsSum2.ForeColor = Color.White;
            lblAmountsSum2.Location = new Point(246, 517);
            lblAmountsSum2.Name = "lblAmountsSum2";
            lblAmountsSum2.Size = new Size(71, 33);
            lblAmountsSum2.TabIndex = 2;
            lblAmountsSum2.Text = "label2";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(829, 602);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(241, 39);
            btnBack.TabIndex = 3;
            btnBack.Text = "بازگشت به پنل رستوران";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resInvoiceDataGridView);
            groupBox1.Controls.Add(lblAmountsSum1);
            groupBox1.Controls.Add(lblAmountsSum2);
            groupBox1.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(227, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 569);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "سفارشات";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // RestaurantInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1082, 653);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RestaurantInvoice";
            RightToLeft = RightToLeft.Yes;
            Text = "فاکتورها";
            Load += RestaurantInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)resInvoiceDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resInvoiceDataGridView;
        private Label lblAmountsSum1;
        private Label lblAmountsSum2;
        private Button btnBack;
        private GroupBox groupBox1;
    }
}