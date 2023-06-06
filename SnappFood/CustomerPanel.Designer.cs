namespace SnappFood
{
    partial class CustomerPanel
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
            SearchGroupBox = new GroupBox();
            SearchBtn = new Button();
            textBox1 = new TextBox();
            RestaurantGroupBox = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SearchGroupBox.SuspendLayout();
            RestaurantGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(SearchBtn);
            SearchGroupBox.Controls.Add(textBox1);
            SearchGroupBox.Location = new Point(27, 29);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(951, 141);
            SearchGroupBox.TabIndex = 0;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Enter += groupBox1_Enter;
            // 
            // SearchBtn
            // 
            SearchBtn.ForeColor = Color.Black;
            SearchBtn.Location = new Point(35, 63);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(94, 29);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "جستجو";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(157, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(746, 27);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "از بین لیست رستوران ها جستجو کنید";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.WordWrap = false;
            // 
            // RestaurantGroupBox
            // 
            RestaurantGroupBox.Controls.Add(flowLayoutPanel1);
            RestaurantGroupBox.Location = new Point(27, 186);
            RestaurantGroupBox.Margin = new Padding(20);
            RestaurantGroupBox.Name = "RestaurantGroupBox";
            RestaurantGroupBox.Size = new Size(951, 333);
            RestaurantGroupBox.TabIndex = 1;
            RestaurantGroupBox.TabStop = false;
            RestaurantGroupBox.Enter += RestaurantGroupBox_Enter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.ForeColor = Color.IndianRed;
            flowLayoutPanel1.Location = new Point(0, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(951, 324);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // CustomerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(996, 549);
            Controls.Add(RestaurantGroupBox);
            Controls.Add(SearchGroupBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CustomerPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerPanel";
            Load += CustomerPanel_Load;
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            RestaurantGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SearchGroupBox;
        private GroupBox RestaurantGroupBox;
        private Button SearchBtn;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}