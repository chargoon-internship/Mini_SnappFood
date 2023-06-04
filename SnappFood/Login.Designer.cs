namespace SnappFood
{
    partial class Login
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UserLogin = new Label();
            PassLogin = new Label();
            txt_userPass = new TextBox();
            txt_userLogin = new TextBox();
            buttonSignUp = new Button();
            buttonLogin = new Button();
            buttonRestaurant = new Button();
            buttonCustomer = new Button();
            btnBack = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblCode = new Label();
            lblAddress = new Label();
            txtFirstName = new TextBox();
            txtCode = new TextBox();
            txtAddress = new TextBox();
            buttonSubmit = new Button();
            buttonGoBack = new Button();
            lbl_last = new Label();
            TimeEnd = new MaskedTextBox();
            TimeBegin = new MaskedTextBox();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("IRANSansWeb(FaNum)", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(429, 38);
            label1.Name = "label1";
            label1.Size = new Size(341, 40);
            label1.TabIndex = 0;
            label1.Text = "به نرم افزار اسنپ فود خوش آمدید";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_2_;
            pictureBox1.Location = new Point(485, 91);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UserLogin
            // 
            UserLogin.AutoSize = true;
            UserLogin.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserLogin.ForeColor = Color.White;
            UserLogin.Location = new Point(374, 271);
            UserLogin.Name = "UserLogin";
            UserLogin.Size = new Size(75, 27);
            UserLogin.TabIndex = 2;
            UserLogin.Text = "نام کاربری";
            // 
            // PassLogin
            // 
            PassLogin.AutoSize = true;
            PassLogin.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassLogin.ForeColor = Color.White;
            PassLogin.Location = new Point(388, 308);
            PassLogin.Name = "PassLogin";
            PassLogin.Size = new Size(61, 27);
            PassLogin.TabIndex = 3;
            PassLogin.Text = "رمز عبور";
            // 
            // txt_userPass
            // 
            txt_userPass.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_userPass.Location = new Point(486, 304);
            txt_userPass.Margin = new Padding(3, 2, 3, 2);
            txt_userPass.Name = "txt_userPass";
            txt_userPass.Size = new Size(254, 34);
            txt_userPass.TabIndex = 4;
            // 
            // txt_userLogin
            // 
            txt_userLogin.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_userLogin.Location = new Point(486, 268);
            txt_userLogin.Margin = new Padding(3, 2, 3, 2);
            txt_userLogin.Name = "txt_userLogin";
            txt_userLogin.Size = new Size(254, 34);
            txt_userLogin.TabIndex = 5;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.FromArgb(236, 12, 109);
            buttonSignUp.FlatStyle = FlatStyle.Popup;
            buttonSignUp.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(486, 345);
            buttonSignUp.Margin = new Padding(3, 2, 3, 2);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(82, 28);
            buttonSignUp.TabIndex = 6;
            buttonSignUp.Text = "ثبت نام";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += button1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(236, 12, 109);
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(657, 345);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(82, 28);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "ورود";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRestaurant
            // 
            buttonRestaurant.BackColor = Color.FromArgb(236, 12, 109);
            buttonRestaurant.FlatStyle = FlatStyle.Popup;
            buttonRestaurant.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRestaurant.Location = new Point(486, 340);
            buttonRestaurant.Margin = new Padding(3, 2, 3, 2);
            buttonRestaurant.Name = "buttonRestaurant";
            buttonRestaurant.Size = new Size(254, 32);
            buttonRestaurant.TabIndex = 8;
            buttonRestaurant.Text = "ثبت نام رستوران";
            buttonRestaurant.UseVisualStyleBackColor = false;
            buttonRestaurant.Click += buttonRestaurant_Click;
            // 
            // buttonCustomer
            // 
            buttonCustomer.BackColor = Color.FromArgb(236, 12, 109);
            buttonCustomer.FlatStyle = FlatStyle.Popup;
            buttonCustomer.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustomer.Location = new Point(486, 304);
            buttonCustomer.Margin = new Padding(3, 2, 3, 2);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(254, 32);
            buttonCustomer.TabIndex = 9;
            buttonCustomer.Text = "ثبت نام کاربر";
            buttonCustomer.UseVisualStyleBackColor = false;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(236, 12, 109);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(486, 380);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 28);
            btnBack.TabIndex = 10;
            btnBack.Text = "بازگشت";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(407, 342);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(30, 27);
            lblFirstName.TabIndex = 11;
            lblFirstName.Text = "نام";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(354, 377);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(93, 27);
            lblLastName.TabIndex = 12;
            lblLastName.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(486, 375);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(254, 34);
            txtLastName.TabIndex = 13;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCode.ForeColor = Color.White;
            lblCode.Location = new Point(371, 412);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(58, 27);
            lblCode.TabIndex = 14;
            lblCode.Text = "کد ملی";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(382, 448);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 27);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "آدرس";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(485, 340);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(254, 34);
            txtFirstName.TabIndex = 16;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.Location = new Point(486, 410);
            txtCode.Margin = new Padding(3, 2, 3, 2);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(254, 34);
            txtCode.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(485, 446);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(254, 32);
            txtAddress.TabIndex = 18;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.FromArgb(236, 12, 109);
            buttonSubmit.FlatStyle = FlatStyle.Popup;
            buttonSubmit.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubmit.Location = new Point(486, 507);
            buttonSubmit.Margin = new Padding(3, 2, 3, 2);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(254, 32);
            buttonSubmit.TabIndex = 19;
            buttonSubmit.Text = "ثبت اطلاعات";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonGoBack
            // 
            buttonGoBack.BackColor = Color.FromArgb(236, 12, 109);
            buttonGoBack.FlatStyle = FlatStyle.Popup;
            buttonGoBack.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGoBack.Location = new Point(485, 544);
            buttonGoBack.Margin = new Padding(3, 2, 3, 2);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(254, 32);
            buttonGoBack.TabIndex = 20;
            buttonGoBack.Text = "بازگشت";
            buttonGoBack.UseVisualStyleBackColor = false;
            buttonGoBack.Click += buttonGoBack_Click;
            // 
            // lbl_last
            // 
            lbl_last.AutoSize = true;
            lbl_last.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_last.ForeColor = Color.White;
            lbl_last.Location = new Point(598, 481);
            lbl_last.Name = "lbl_last";
            lbl_last.Size = new Size(22, 27);
            lbl_last.TabIndex = 22;
            lbl_last.Text = "تا";
            // 
            // TimeEnd
            // 
            TimeEnd.Location = new Point(655, 482);
            TimeEnd.Margin = new Padding(3, 2, 3, 2);
            TimeEnd.Mask = "00:00";
            TimeEnd.Name = "TimeEnd";
            TimeEnd.Size = new Size(84, 23);
            TimeEnd.TabIndex = 23;
            TimeEnd.TextAlign = HorizontalAlignment.Center;
            TimeEnd.ValidatingType = typeof(DateTime);
            // 
            // TimeBegin
            // 
            TimeBegin.Location = new Point(486, 482);
            TimeBegin.Margin = new Padding(3, 2, 3, 2);
            TimeBegin.Mask = "00:00";
            TimeBegin.Name = "TimeBegin";
            TimeBegin.Size = new Size(84, 23);
            TimeBegin.TabIndex = 24;
            TimeBegin.TextAlign = HorizontalAlignment.Center;
            TimeBegin.ValidatingType = typeof(DateTime);
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(347, 481);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(99, 27);
            lblTime.TabIndex = 25;
            lblTime.Text = "ساعت کار کرد";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(1186, 536);
            Controls.Add(lblTime);
            Controls.Add(TimeBegin);
            Controls.Add(TimeEnd);
            Controls.Add(lbl_last);
            Controls.Add(buttonGoBack);
            Controls.Add(buttonSubmit);
            Controls.Add(txtAddress);
            Controls.Add(txtCode);
            Controls.Add(txtFirstName);
            Controls.Add(lblAddress);
            Controls.Add(lblCode);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnBack);
            Controls.Add(buttonCustomer);
            Controls.Add(buttonRestaurant);
            Controls.Add(UserLogin);
            Controls.Add(PassLogin);
            Controls.Add(buttonSignUp);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(txt_userPass);
            Controls.Add(txt_userLogin);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label UserLogin;
        private Label PassLogin;
        private TextBox txt_userPass;
        private TextBox txt_userLogin;
        private Button buttonSignUp;
        private Button buttonLogin;
        private Button buttonRestaurant;
        private Button buttonCustomer;
        private Button btnBack;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblCode;
        private Label lblAddress;
        private TextBox txtFirstName;
        private TextBox txtCode;
        private TextBox txtAddress;
        private Button buttonSubmit;
        private Button buttonGoBack;
        private Label lbl_last;
        private MaskedTextBox TimeEnd;
        private MaskedTextBox TimeBegin;
        private Label lblTime;
    }
}