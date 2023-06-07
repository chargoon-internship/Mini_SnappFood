namespace SnappFood
{
    partial class CustomerInvoice
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
            userInvoiceDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label1 = new Label();
            lblSum = new Label();
            lblAmount = new Label();
            btnPayment = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)userInvoiceDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // userInvoiceDataGridView
            // 
            userInvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userInvoiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            userInvoiceDataGridView.Location = new Point(143, 51);
            userInvoiceDataGridView.Name = "userInvoiceDataGridView";
            userInvoiceDataGridView.RowHeadersWidth = 51;
            userInvoiceDataGridView.RowTemplate.Height = 29;
            userInvoiceDataGridView.Size = new Size(700, 470);
            userInvoiceDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "نام غذا";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
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
            Column3.Width = 230;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "FinalPrice";
            Column4.HeaderText = "قیمت";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblSum);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Controls.Add(userInvoiceDataGridView);
            groupBox1.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(35, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1010, 577);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "صورتحساب";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 524);
            label1.Name = "label1";
            label1.Size = new Size(58, 33);
            label1.TabIndex = 3;
            label1.Text = "تومان";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblSum.Location = new Point(316, 524);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(66, 33);
            lblSum.TabIndex = 2;
            lblSum.Text = "label1";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(143, 524);
            lblAmount.Name = "lblAmount";
            lblAmount.RightToLeft = RightToLeft.No;
            lblAmount.Size = new Size(167, 33);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "مبلغ قابل پرداخت :";
            lblAmount.Click += lblAmount_Click;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnPayment.Location = new Point(702, 595);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(112, 38);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "پرداخت";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(820, 595);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(225, 38);
            btnBack.TabIndex = 3;
            btnBack.Text = "بازگشت به منوی رستوران";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CustomerInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1082, 653);
            Controls.Add(btnBack);
            Controls.Add(btnPayment);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb(FaNum)", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerInvoice";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاکتور مشتری";
            Load += CustomerInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)userInvoiceDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userInvoiceDataGridView;
        private GroupBox groupBox1;
        private Label lblSum;
        private Label lblAmount;
        private Button btnPayment;
        private Button btnBack;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}