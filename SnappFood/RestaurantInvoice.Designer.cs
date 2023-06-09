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
            FoodNames = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            FinalPrice = new DataGridViewTextBoxColumn();
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
            resInvoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resInvoiceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resInvoiceDataGridView.Columns.AddRange(new DataGridViewColumn[] { FoodNames, Number, Description, Time, FinalPrice });
            resInvoiceDataGridView.Dock = DockStyle.Fill;
            resInvoiceDataGridView.Location = new Point(3, 38);
            resInvoiceDataGridView.Margin = new Padding(3, 5, 3, 5);
            resInvoiceDataGridView.Name = "resInvoiceDataGridView";
            resInvoiceDataGridView.RowHeadersWidth = 51;
            resInvoiceDataGridView.RowTemplate.Height = 24;
            resInvoiceDataGridView.Size = new Size(897, 522);
            resInvoiceDataGridView.TabIndex = 0;
            // 
            // FoodNames
            // 
            FoodNames.DataPropertyName = "Foods";
            FoodNames.HeaderText = "نام غذا";
            FoodNames.MinimumWidth = 6;
            FoodNames.Name = "FoodNames";
            // 
            // Number
            // 
            Number.DataPropertyName = "Number";
            Number.HeaderText = "تعداد";
            Number.MinimumWidth = 6;
            Number.Name = "Number";
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "توضیحات";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // Time
            // 
            Time.DataPropertyName = "Time";
            Time.HeaderText = "زمان ثبت سفارش";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            // 
            // FinalPrice
            // 
            FinalPrice.DataPropertyName = "FinalPrice";
            FinalPrice.HeaderText = "مبلغ";
            FinalPrice.MinimumWidth = 6;
            FinalPrice.Name = "FinalPrice";
            // 
            // lblAmountsSum1
            // 
            lblAmountsSum1.AutoSize = true;
            lblAmountsSum1.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmountsSum1.ForeColor = Color.White;
            lblAmountsSum1.Location = new Point(95, 590);
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
            lblAmountsSum2.Location = new Point(288, 590);
            lblAmountsSum2.Name = "lblAmountsSum2";
            lblAmountsSum2.Size = new Size(24, 33);
            lblAmountsSum2.TabIndex = 2;
            lblAmountsSum2.Text = "0";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("IRANSansWeb(FaNum)", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(737, 590);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(258, 38);
            btnBack.TabIndex = 3;
            btnBack.Text = "بازگشت به پنل رستوران";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resInvoiceDataGridView);
            groupBox1.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(92, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(903, 564);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "سفارشات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(318, 595);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 3;
            label1.Text = "تومان";
            label1.Click += label1_Click;
            // 
            // RestaurantInvoice
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1082, 653);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(lblAmountsSum1);
            Controls.Add(lblAmountsSum2);
            Font = new Font("IRANSansWeb(FaNum)", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 5, 3, 5);
            Name = "RestaurantInvoice";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاکتور رستوران";
            ((System.ComponentModel.ISupportInitialize)resInvoiceDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView resInvoiceDataGridView;
        private Label lblAmountsSum1;
        private Label lblAmountsSum2;
        private Button btnBack;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridViewTextBoxColumn FoodNames;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn FinalPrice;
    }
}