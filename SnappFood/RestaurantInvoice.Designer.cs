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
            FoodName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lblAmountsSum1 = new Label();
            lblAmountsSum2 = new Label();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)resInvoiceDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // resInvoiceDataGridView
            // 
            resInvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resInvoiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { FoodName, Column2, Column3, Column4, Column5 });
            resInvoiceDataGridView.Location = new Point(53, 41);
            resInvoiceDataGridView.Margin = new Padding(3, 4, 3, 4);
            resInvoiceDataGridView.Name = "resInvoiceDataGridView";
            resInvoiceDataGridView.RowHeadersWidth = 51;
            resInvoiceDataGridView.RowTemplate.Height = 24;
            resInvoiceDataGridView.Size = new Size(732, 472);
            resInvoiceDataGridView.TabIndex = 0;
            // 
            // FoodName
            // 
            FoodName.DataPropertyName = "FoodName";
            FoodName.HeaderText = "نام غذا";
            FoodName.MinimumWidth = 6;
            FoodName.Name = "FoodName";
            FoodName.Width = 160;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Number";
            Column2.HeaderText = "تعداد";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Description";
            Column3.HeaderText = "توضیحات";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Time";
            Column4.HeaderText = "زمان ثبت سفارش";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 160;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "FinalPrice";
            Column5.HeaderText = "مبلغ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
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
            btnBack.Click += btnBack_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(resInvoiceDataGridView);
            groupBox1.Controls.Add(lblAmountsSum1);
            groupBox1.Controls.Add(lblAmountsSum2);
            groupBox1.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(121, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(834, 569);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "سفارشات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 517);
            label1.Name = "label1";
            label1.Size = new Size(58, 33);
            label1.TabIndex = 3;
            label1.Text = "تومان";
            label1.Click += label1_Click;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاکتور رستوران";
            Load += RestaurantInvoice_Load_1;
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
        private Label label1;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}