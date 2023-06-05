namespace SnappFood
{
    partial class EditProfile
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
            pictureProfile = new PictureBox();
            lblWelcome = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblCode = new Label();
            lblAddress = new Label();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtNationalCode = new TextBox();
            txtAddress = new TextBox();
            lblTime = new Label();
            TimeBegin = new MaskedTextBox();
            lbl_last = new Label();
            TimeEnd = new MaskedTextBox();
            btnEdit = new Button();
            btnExit = new Button();
            txtNameRestaurant = new TextBox();
            lblNameRestaurant = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureProfile).BeginInit();
            SuspendLayout();
            // 
            // pictureProfile
            // 
            pictureProfile.Image = Properties.Resources.user_2_;
            pictureProfile.Location = new Point(131, 42);
            pictureProfile.Margin = new Padding(2);
            pictureProfile.Name = "pictureProfile";
            pictureProfile.Size = new Size(121, 72);
            pictureProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProfile.TabIndex = 2;
            pictureProfile.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("IRANSansWeb(FaNum)", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(131, 8);
            lblWelcome.Margin = new Padding(2, 0, 2, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(133, 32);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "ویرایش پروفایل";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(41, 133);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(63, 22);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "نام کاربری";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(50, 167);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(50, 22);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "رمز عبور";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(68, 211);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(25, 22);
            lblFirstName.TabIndex = 12;
            lblFirstName.Text = "نام";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(16, 241);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(77, 22);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "نام خانوادگی";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCode.ForeColor = Color.White;
            lblCode.Location = new Point(45, 281);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(48, 22);
            lblCode.TabIndex = 15;
            lblCode.Text = "کد ملی";
            lblCode.Visible = false;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(10, 318);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 22);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "آدرس رستوران";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(111, 130);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(168, 29);
            txtUserName.TabIndex = 27;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(111, 167);
            txtPassWord.Margin = new Padding(4);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(168, 29);
            txtPassWord.TabIndex = 28;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(111, 204);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(168, 29);
            txtFirstName.TabIndex = 29;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(111, 241);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(168, 29);
            txtLastName.TabIndex = 30;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(111, 278);
            txtNationalCode.Margin = new Padding(4);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(168, 29);
            txtNationalCode.TabIndex = 31;
            txtNationalCode.Visible = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(111, 315);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(168, 29);
            txtAddress.TabIndex = 32;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(12, 369);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(81, 22);
            lblTime.TabIndex = 26;
            lblTime.Text = "ساعت کار کرد";
            lblTime.Visible = false;
            // 
            // TimeBegin
            // 
            TimeBegin.Location = new Point(111, 362);
            TimeBegin.Margin = new Padding(3, 2, 3, 2);
            TimeBegin.Mask = "00:00";
            TimeBegin.Name = "TimeBegin";
            TimeBegin.Size = new Size(61, 29);
            TimeBegin.TabIndex = 33;
            TimeBegin.TextAlign = HorizontalAlignment.Center;
            TimeBegin.ValidatingType = typeof(DateTime);
            TimeBegin.Visible = false;
            // 
            // lbl_last
            // 
            lbl_last.AutoSize = true;
            lbl_last.Font = new Font("IRANSansWeb(FaNum)", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_last.ForeColor = Color.White;
            lbl_last.Location = new Point(178, 364);
            lbl_last.Name = "lbl_last";
            lbl_last.Size = new Size(22, 27);
            lbl_last.TabIndex = 34;
            lbl_last.Text = "تا";
            lbl_last.Visible = false;
            // 
            // TimeEnd
            // 
            TimeEnd.Location = new Point(216, 362);
            TimeEnd.Margin = new Padding(3, 2, 3, 2);
            TimeEnd.Mask = "00:00";
            TimeEnd.Name = "TimeEnd";
            TimeEnd.Size = new Size(64, 29);
            TimeEnd.TabIndex = 35;
            TimeEnd.TextAlign = HorizontalAlignment.Center;
            TimeEnd.ValidatingType = typeof(DateTime);
            TimeEnd.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(236, 12, 109);
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(41, 407);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 41);
            btnEdit.TabIndex = 36;
            btnEdit.Text = "ویرایش اطلاعات";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += buttonEdit_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(236, 12, 109);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("IRANSansWeb(FaNum)", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(206, 407);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 41);
            btnExit.TabIndex = 38;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // txtNameRestaurant
            // 
            txtNameRestaurant.Location = new Point(111, 278);
            txtNameRestaurant.Margin = new Padding(4);
            txtNameRestaurant.Name = "txtNameRestaurant";
            txtNameRestaurant.Size = new Size(168, 29);
            txtNameRestaurant.TabIndex = 40;
            txtNameRestaurant.Visible = false;
            // 
            // lblNameRestaurant
            // 
            lblNameRestaurant.AutoSize = true;
            lblNameRestaurant.Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameRestaurant.ForeColor = Color.White;
            lblNameRestaurant.Location = new Point(24, 281);
            lblNameRestaurant.Name = "lblNameRestaurant";
            lblNameRestaurant.Size = new Size(69, 22);
            lblNameRestaurant.TabIndex = 39;
            lblNameRestaurant.Text = "نام رستوران";
            lblNameRestaurant.Visible = false;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 0, 79);
            ClientSize = new Size(366, 467);
            Controls.Add(txtNameRestaurant);
            Controls.Add(lblNameRestaurant);
            Controls.Add(btnExit);
            Controls.Add(btnEdit);
            Controls.Add(TimeEnd);
            Controls.Add(lbl_last);
            Controls.Add(TimeBegin);
            Controls.Add(txtAddress);
            Controls.Add(txtNationalCode);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(lblTime);
            Controls.Add(lblAddress);
            Controls.Add(lblCode);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblWelcome);
            Controls.Add(pictureProfile);
            Font = new Font("IRANSansWeb(FaNum)", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditProfile";
            RightToLeft = RightToLeft.Yes;
            Text = "ویرایش پروفایل";
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureProfile;
        private Label lblWelcome;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblCode;
        private Label lblAddress;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtNationalCode;
        private TextBox txtAddress;
        private Label lblTime;
        private MaskedTextBox TimeBegin;
        private Label lbl_last;
        private MaskedTextBox TimeEnd;
        private Button btnEdit;
        private Button btnExit;
        private TextBox txtNameRestaurant;
        private Label lblNameRestaurant;
    }
}