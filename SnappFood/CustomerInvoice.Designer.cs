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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userInvoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.FoodNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userInvoiceDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInvoiceDataGridView
            // 
            this.userInvoiceDataGridView.AllowUserToAddRows = false;
            this.userInvoiceDataGridView.AllowUserToDeleteRows = false;
            this.userInvoiceDataGridView.AllowUserToResizeColumns = false;
            this.userInvoiceDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userInvoiceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInvoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodNames,
            this.Number,
            this.FinalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userInvoiceDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.userInvoiceDataGridView.Location = new System.Drawing.Point(143, 51);
            this.userInvoiceDataGridView.Name = "userInvoiceDataGridView";
            this.userInvoiceDataGridView.ReadOnly = true;
            this.userInvoiceDataGridView.RowHeadersWidth = 51;
            this.userInvoiceDataGridView.RowTemplate.Height = 29;
            this.userInvoiceDataGridView.Size = new System.Drawing.Size(700, 348);
            this.userInvoiceDataGridView.TabIndex = 0;
            // 
            // FoodNames
            // 
            this.FoodNames.DataPropertyName = "Name";
            this.FoodNames.HeaderText = "نام غذا";
            this.FoodNames.MinimumWidth = 6;
            this.FoodNames.Name = "FoodNames";
            this.FoodNames.ReadOnly = true;
            this.FoodNames.Width = 245;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Quantity";
            this.Number.HeaderText = "تعداد";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 200;
            // 
            // FinalPrice
            // 
            this.FinalPrice.DataPropertyName = "Price";
            this.FinalPrice.HeaderText = "قیمت";
            this.FinalPrice.MinimumWidth = 6;
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.ReadOnly = true;
            this.FinalPrice.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.userInvoiceDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 577);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صورتحساب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "تومان";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSum.Location = new System.Drawing.Point(320, 412);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(66, 33);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "label1";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(143, 412);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmount.Size = new System.Drawing.Size(167, 33);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "مبلغ قابل پرداخت :";
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.Location = new System.Drawing.Point(702, 595);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(112, 38);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "پرداخت";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(820, 595);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(225, 38);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "بازگشت به منوی رستوران";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "توضیحات";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(143, 454);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(700, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // CustomerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاکتور مشتری";
            this.Load += new System.EventHandler(this.CustomerInvoice_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.userInvoiceDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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