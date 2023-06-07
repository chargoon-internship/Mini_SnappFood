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
            label1 = new Label();
            SearchBtn = new Button();
            Searchtxt = new TextBox();
            RestaurantGroupBox = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            EditProfileBtn = new Button();
            SearchGroupBox.SuspendLayout();
            RestaurantGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(label1);
            SearchGroupBox.Controls.Add(SearchBtn);
            SearchGroupBox.Controls.Add(Searchtxt);
            SearchGroupBox.Location = new Point(192, 29);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Size = new Size(1174, 141);
            SearchGroupBox.TabIndex = 0;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(789, 23);
            label1.Name = "label1";
            label1.Size = new Size(337, 29);
            label1.TabIndex = 2;
            label1.Text = "از بین لیست رستوران ها جستجو کنید";
            // 
            // SearchBtn
            // 
            SearchBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.Black;
            SearchBtn.Location = new Point(21, 64);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(139, 45);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "جستجو";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Searchtxt
            // 
            Searchtxt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Searchtxt.ForeColor = Color.Silver;
            Searchtxt.Location = new Point(176, 72);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(970, 28);
            Searchtxt.TabIndex = 0;
            Searchtxt.TabStop = false;
            Searchtxt.TextAlign = HorizontalAlignment.Center;
            Searchtxt.WordWrap = false;
            // 
            // RestaurantGroupBox
            // 
            RestaurantGroupBox.Controls.Add(flowLayoutPanel1);
            RestaurantGroupBox.Location = new Point(27, 186);
            RestaurantGroupBox.Margin = new Padding(20);
            RestaurantGroupBox.Name = "RestaurantGroupBox";
            RestaurantGroupBox.Size = new Size(1344, 585);
            RestaurantGroupBox.TabIndex = 1;
            RestaurantGroupBox.TabStop = false;
            RestaurantGroupBox.Enter += RestaurantGroupBox_Enter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.ForeColor = Color.IndianRed;
            flowLayoutPanel1.Location = new Point(0, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1344, 575);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // EditProfileBtn
            // 
            EditProfileBtn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            EditProfileBtn.ForeColor = Color.Black;
            EditProfileBtn.Location = new Point(27, 93);
            EditProfileBtn.Name = "EditProfileBtn";
            EditProfileBtn.RightToLeft = RightToLeft.Yes;
            EditProfileBtn.Size = new Size(153, 45);
            EditProfileBtn.TabIndex = 4;
            EditProfileBtn.Text = "مشاهده پروفایل";
            EditProfileBtn.UseVisualStyleBackColor = true;
            EditProfileBtn.Click += EditProfileBtn_Click;
            // 
            // CustomerPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1400, 800);
            Controls.Add(EditProfileBtn);
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
        private TextBox Searchtxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button EditProfileBtn;
        private Label label1;
    }
}