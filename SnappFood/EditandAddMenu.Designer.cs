namespace SnappFood
{
    partial class EditandAddMenu
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtID = new TextBox();
            chBoxExistence = new CheckBox();
            label3 = new Label();
            btnSubmit = new Button();
            txtPrice = new MaskedTextBox();
            label2 = new Label();
            txtFood = new TextBox();
            label1 = new Label();
            gbMenu = new GroupBox();
            dgMenu = new DataGridView();
            FoodID = new DataGridViewTextBoxColumn();
            NameOfFood = new DataGridViewTextBoxColumn();
            PriceOfFood = new DataGridViewTextBoxColumn();
            ExistenceOfFood = new DataGridViewTextBoxColumn();
            btnEditMenu = new Button();
            btnDeletMenu = new Button();
            btnReturn = new Button();
            groupBox1.SuspendLayout();
            gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMenu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(chBoxExistence);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFood);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 19);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(899, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(748, 112);
            label4.Name = "label4";
            label4.Size = new Size(113, 18);
            label4.TabIndex = 8;
            label4.Text = "شماره شناسایی رستوران";
            label4.Visible = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(627, 104);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 26);
            txtID.TabIndex = 7;
            txtID.Visible = false;
            // 
            // chBoxExistence
            // 
            chBoxExistence.AutoSize = true;
            chBoxExistence.Location = new Point(225, 59);
            chBoxExistence.Margin = new Padding(4);
            chBoxExistence.Name = "chBoxExistence";
            chBoxExistence.Size = new Size(15, 14);
            chBoxExistence.TabIndex = 6;
            chBoxExistence.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("IRANSansWeb(FaNum)", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(248, 51);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 5;
            label3.Text = "موجودی غذا";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(37, 55);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(88, 32);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "ثبت";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnAddFood_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(373, 53);
            txtPrice.Margin = new Padding(4);
            txtPrice.Mask = "\"###,###,## ریال\"";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(163, 26);
            txtPrice.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("IRANSansWeb(FaNum)", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(544, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 2;
            label2.Text = "قیمت غذا";
            // 
            // txtFood
            // 
            txtFood.Location = new Point(642, 51);
            txtFood.Margin = new Padding(4);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(168, 26);
            txtFood.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("IRANSansWeb(FaNum)", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(817, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 32);
            label1.TabIndex = 0;
            label1.Text = "نام غذا";
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(dgMenu);
            gbMenu.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbMenu.Location = new Point(18, 188);
            gbMenu.Margin = new Padding(4);
            gbMenu.Name = "gbMenu";
            gbMenu.Padding = new Padding(4);
            gbMenu.Size = new Size(901, 430);
            gbMenu.TabIndex = 1;
            gbMenu.TabStop = false;
            // 
            // dgMenu
            // 
            dgMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMenu.Columns.AddRange(new DataGridViewColumn[] { FoodID, NameOfFood, PriceOfFood, ExistenceOfFood });
            dgMenu.Dock = DockStyle.Fill;
            dgMenu.Location = new Point(4, 18);
            dgMenu.Margin = new Padding(4);
            dgMenu.Name = "dgMenu";
            dgMenu.Size = new Size(893, 408);
            dgMenu.TabIndex = 0;
            // 
            // FoodID
            // 
            FoodID.DataPropertyName = "Id";
            FoodID.HeaderText = "FoodID";
            FoodID.Name = "FoodID";
            FoodID.Visible = false;
            // 
            // NameOfFood
            // 
            NameOfFood.DataPropertyName = "Name";
            NameOfFood.HeaderText = "نام غذا";
            NameOfFood.Name = "NameOfFood";
            // 
            // PriceOfFood
            // 
            PriceOfFood.DataPropertyName = "Price";
            PriceOfFood.HeaderText = "قیمت غذا";
            PriceOfFood.Name = "PriceOfFood";
            // 
            // ExistenceOfFood
            // 
            ExistenceOfFood.DataPropertyName = "Exist";
            ExistenceOfFood.HeaderText = "موجودی";
            ExistenceOfFood.Name = "ExistenceOfFood";
            // 
            // btnEditMenu
            // 
            btnEditMenu.Location = new Point(173, 626);
            btnEditMenu.Margin = new Padding(4);
            btnEditMenu.Name = "btnEditMenu";
            btnEditMenu.Size = new Size(88, 32);
            btnEditMenu.TabIndex = 2;
            btnEditMenu.Text = "ویرایش";
            btnEditMenu.UseVisualStyleBackColor = true;
            btnEditMenu.Visible = false;
            btnEditMenu.Click += btnEditMenu_Click;
            // 
            // btnDeletMenu
            // 
            btnDeletMenu.Location = new Point(55, 626);
            btnDeletMenu.Margin = new Padding(4);
            btnDeletMenu.Name = "btnDeletMenu";
            btnDeletMenu.Size = new Size(88, 32);
            btnDeletMenu.TabIndex = 3;
            btnDeletMenu.Text = "حذف";
            btnDeletMenu.UseVisualStyleBackColor = true;
            btnDeletMenu.Visible = false;
            btnDeletMenu.Click += btnDeletMenu_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(810, 626);
            btnReturn.Margin = new Padding(4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(88, 32);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "بازگشت";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // EditandAddMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(929, 666);
            Controls.Add(btnReturn);
            Controls.Add(btnDeletMenu);
            Controls.Add(btnEditMenu);
            Controls.Add(gbMenu);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb(FaNum)", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "EditandAddMenu";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "منو رستوران";
            Load += EditandAddMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.CheckBox chBoxExistence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.Button btnEditMenu;
        private System.Windows.Forms.Button btnDeletMenu;
        private Label label4;
        private TextBox txtID;
        private DataGridViewTextBoxColumn FoodID;
        private DataGridViewTextBoxColumn NameOfFood;
        private DataGridViewTextBoxColumn PriceOfFood;
        private DataGridViewTextBoxColumn ExistenceOfFood;
        private Button btnReturn;
    }
}

