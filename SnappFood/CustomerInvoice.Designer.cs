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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            userInvoiceDataGridView = new DataGridView();
            FoodNames = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            FinalPrice = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
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
            userInvoiceDataGridView.AllowUserToAddRows = false;
            userInvoiceDataGridView.AllowUserToDeleteRows = false;
            userInvoiceDataGridView.AllowUserToResizeColumns = false;
            userInvoiceDataGridView.AllowUserToResizeRows = false;
            userInvoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            userInvoiceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            userInvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userInvoiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { FoodNames, Number, FinalPrice });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userInvoiceDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            userInvoiceDataGridView.Location = new Point(143, 51);
            userInvoiceDataGridView.Name = "userInvoiceDataGridView";
            userInvoiceDataGridView.ReadOnly = true;
            userInvoiceDataGridView.RowHeadersWidth = 51;
            userInvoiceDataGridView.RowTemplate.Height = 29;
            userInvoiceDataGridView.Size = new Size(700, 348);
            userInvoiceDataGridView.TabIndex = 0;
            // 
            // FoodNames
            // 
            FoodNames.DataPropertyName = "Name";
            FoodNames.HeaderText = "نام غذا";
            FoodNames.MinimumWidth = 6;
            FoodNames.Name = "FoodNames";
            FoodNames.ReadOnly = true;
            // 
            // Number
            // 
            Number.DataPropertyName = "Quantity";
            Number.HeaderText = "تعداد";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // FinalPrice
            // 
            FinalPrice.DataPropertyName = "Price";
            FinalPrice.HeaderText = "قیمت";
            FinalPrice.MinimumWidth = 6;
            FinalPrice.Name = "FinalPrice";
            FinalPrice.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblSum);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Controls.Add(userInvoiceDataGridView);
            groupBox1.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(35, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1010, 577);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "صورتحساب";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(143, 454);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(700, 96);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(849, 457);
            label2.Name = "label2";
            label2.Size = new Size(91, 33);
            label2.TabIndex = 4;
            label2.Text = "توضیحات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 402);
            label1.Name = "label1";
            label1.Size = new Size(58, 33);
            label1.TabIndex = 3;
            label1.Text = "تومان";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSum.Location = new Point(316, 402);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(24, 33);
            lblSum.TabIndex = 2;
            lblSum.Text = "0";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(143, 402);
            lblAmount.Name = "lblAmount";
            lblAmount.RightToLeft = RightToLeft.No;
            lblAmount.Size = new Size(167, 33);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "مبلغ قابل پرداخت :";
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            btnBack.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            Load += CustomerInvoice_Load_1;
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
        private DataGridViewTextBoxColumn FoodNames;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn FinalPrice;
        private RichTextBox richTextBox1;
        private Label label2;
    }
}