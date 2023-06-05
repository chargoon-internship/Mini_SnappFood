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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            lblAmount = new Label();
            lblSum = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(921, 470);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSum);
            groupBox1.Controls.Add(lblAmount);
            groupBox1.Controls.Add(dataGridView1);
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
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(41, 524);
            lblAmount.Name = "lblAmount";
            lblAmount.RightToLeft = RightToLeft.No;
            lblAmount.Size = new Size(167, 33);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "مبلغ قابل پرداخت :";
            lblAmount.Click += lblAmount_Click;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblSum.Location = new Point(235, 524);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(66, 33);
            lblSum.TabIndex = 2;
            lblSum.Text = "label1";
            // 
            // button1
            // 
            button1.Font = new Font("IRANSansWeb(FaNum)", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(933, 603);
            button1.Name = "button1";
            button1.Size = new Size(112, 38);
            button1.TabIndex = 2;
            button1.Text = "پرداخت";
            button1.UseVisualStyleBackColor = true;
            // 
            // CustomerInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1082, 653);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb(FaNum)", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerInvoice";
            RightToLeft = RightToLeft.Yes;
            Text = "فاکتور مشتری";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label lblSum;
        private Label lblAmount;
        private Button button1;
    }
}