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
            Searchtxt = new TextBox();
            RestaurantGroupBox = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            EditProfileBtn = new Button();
            UserNamelbl = new Label();
            SearchGroupBox.SuspendLayout();
            RestaurantGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SearchGroupBox
            // 
            SearchGroupBox.Controls.Add(label1);
            SearchGroupBox.Controls.Add(Searchtxt);
            SearchGroupBox.Location = new Point(188, 60);
            SearchGroupBox.Margin = new Padding(3, 4, 3, 4);
            SearchGroupBox.Name = "SearchGroupBox";
            SearchGroupBox.Padding = new Padding(3, 4, 3, 4);
            SearchGroupBox.Size = new Size(1181, 155);
            SearchGroupBox.TabIndex = 0;
            SearchGroupBox.TabStop = false;
            SearchGroupBox.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.BlanchedAlmond;
            label1.Location = new Point(859, 45);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 2;
            label1.Text = "رستوران مورد نظر را جست و جوکنید";
            // 
            // Searchtxt
            // 
            Searchtxt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Searchtxt.ForeColor = Color.Silver;
            Searchtxt.Location = new Point(43, 95);
            Searchtxt.Margin = new Padding(3, 4, 3, 4);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(1111, 28);
            Searchtxt.TabIndex = 0;
            Searchtxt.TabStop = false;
            Searchtxt.TextAlign = HorizontalAlignment.Center;
            Searchtxt.WordWrap = false;
            Searchtxt.TextChanged += Searchtxt_TextChanged;
            // 
            // RestaurantGroupBox
            // 
            RestaurantGroupBox.Controls.Add(flowLayoutPanel1);
            RestaurantGroupBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RestaurantGroupBox.Location = new Point(34, 237);
            RestaurantGroupBox.Margin = new Padding(21, 30, 21, 30);
            RestaurantGroupBox.Name = "RestaurantGroupBox";
            RestaurantGroupBox.Padding = new Padding(3, 4, 3, 4);
            RestaurantGroupBox.RightToLeft = RightToLeft.Yes;
            RestaurantGroupBox.Size = new Size(1336, 489);
            RestaurantGroupBox.TabIndex = 1;
            RestaurantGroupBox.TabStop = false;
            RestaurantGroupBox.Enter += RestaurantGroupBox_Enter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.ForeColor = Color.IndianRed;
            flowLayoutPanel1.Location = new Point(3, 23);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1330, 462);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // EditProfileBtn
            // 
            EditProfileBtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditProfileBtn.ForeColor = Color.Black;
            EditProfileBtn.Location = new Point(34, 105);
            EditProfileBtn.Margin = new Padding(3, 4, 3, 4);
            EditProfileBtn.Name = "EditProfileBtn";
            EditProfileBtn.RightToLeft = RightToLeft.Yes;
            EditProfileBtn.Size = new Size(131, 79);
            EditProfileBtn.TabIndex = 4;
            EditProfileBtn.Text = "مشاهده پروفایل";
            EditProfileBtn.UseVisualStyleBackColor = true;
            EditProfileBtn.Click += EditProfileBtn_Click;
            // 
            // UserNamelbl
            // 
            UserNamelbl.AutoSize = true;
            UserNamelbl.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UserNamelbl.Location = new Point(607, 9);
            UserNamelbl.Name = "UserNamelbl";
            UserNamelbl.Size = new Size(127, 31);
            UserNamelbl.TabIndex = 5;
            UserNamelbl.Text = "wellcome";
            // 
            // CustomerPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1400, 800);
            Controls.Add(UserNamelbl);
            Controls.Add(EditProfileBtn);
            Controls.Add(RestaurantGroupBox);
            Controls.Add(SearchGroupBox);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerPanel";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerPanel";
            Load += CustomerPanel_Load;
            SearchGroupBox.ResumeLayout(false);
            SearchGroupBox.PerformLayout();
            RestaurantGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SearchGroupBox;
        private GroupBox RestaurantGroupBox;
        private TextBox Searchtxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button EditProfileBtn;
        private Label label1;
        private Label UserNamelbl;
    }
}