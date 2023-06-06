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
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.TimeBegin = new System.Windows.Forms.MaskedTextBox();
            this.lbl_last = new System.Windows.Forms.Label();
            this.TimeEnd = new System.Windows.Forms.MaskedTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNameRestaurant = new System.Windows.Forms.TextBox();
            this.lblNameRestaurant = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureProfile
            // 
            this.pictureProfile.Image = global::SnappFood.Properties.Resources.user_2_;
            this.pictureProfile.Location = new System.Drawing.Point(131, 42);
            this.pictureProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(121, 72);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfile.TabIndex = 2;
            this.pictureProfile.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(131, 8);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(169, 40);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "ویرایش پروفایل";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(41, 133);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 28);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "نام کاربری";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(50, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 28);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "رمز عبور";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(68, 211);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(31, 28);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "نام";
            this.lblFirstName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(16, 241);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(97, 28);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "نام خانوادگی";
            this.lblLastName.Visible = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(45, 281);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(60, 28);
            this.lblCode.TabIndex = 15;
            this.lblCode.Text = "کد ملی";
            this.lblCode.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(50, 322);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 28);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "آدرس";
            this.lblAddress.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(111, 130);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 34);
            this.txtUserName.TabIndex = 27;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(111, 167);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(168, 34);
            this.txtPassWord.TabIndex = 28;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(111, 204);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 34);
            this.txtFirstName.TabIndex = 29;
            this.txtFirstName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(111, 241);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 34);
            this.txtLastName.TabIndex = 30;
            this.txtLastName.Visible = false;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(111, 278);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(168, 34);
            this.txtNationalCode.TabIndex = 31;
            this.txtNationalCode.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(111, 315);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 34);
            this.txtAddress.TabIndex = 32;
            this.txtAddress.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 369);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(104, 28);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = "ساعت کار کرد";
            this.lblTime.Visible = false;
            // 
            // TimeBegin
            // 
            this.TimeBegin.Location = new System.Drawing.Point(111, 362);
            this.TimeBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeBegin.Mask = "00:00";
            this.TimeBegin.Name = "TimeBegin";
            this.TimeBegin.Size = new System.Drawing.Size(61, 34);
            this.TimeBegin.TabIndex = 33;
            this.TimeBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBegin.ValidatingType = typeof(System.DateTime);
            this.TimeBegin.Visible = false;
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_last.ForeColor = System.Drawing.Color.White;
            this.lbl_last.Location = new System.Drawing.Point(178, 364);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(27, 33);
            this.lbl_last.TabIndex = 34;
            this.lbl_last.Text = "تا";
            this.lbl_last.Visible = false;
            // 
            // TimeEnd
            // 
            this.TimeEnd.Location = new System.Drawing.Point(216, 362);
            this.TimeEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeEnd.Mask = "00:00";
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(64, 34);
            this.TimeEnd.TabIndex = 35;
            this.TimeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeEnd.ValidatingType = typeof(System.DateTime);
            this.TimeEnd.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(24, 407);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 49);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "ویرایش اطلاعات";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(239, 407);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 49);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "بازگشت";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtNameRestaurant
            // 
            this.txtNameRestaurant.Location = new System.Drawing.Point(111, 278);
            this.txtNameRestaurant.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameRestaurant.Name = "txtNameRestaurant";
            this.txtNameRestaurant.Size = new System.Drawing.Size(168, 34);
            this.txtNameRestaurant.TabIndex = 40;
            this.txtNameRestaurant.Visible = false;
            // 
            // lblNameRestaurant
            // 
            this.lblNameRestaurant.AutoSize = true;
            this.lblNameRestaurant.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameRestaurant.ForeColor = System.Drawing.Color.White;
            this.lblNameRestaurant.Location = new System.Drawing.Point(24, 285);
            this.lblNameRestaurant.Name = "lblNameRestaurant";
            this.lblNameRestaurant.Size = new System.Drawing.Size(88, 28);
            this.lblNameRestaurant.TabIndex = 39;
            this.lblNameRestaurant.Text = "نام رستوران";
            this.lblNameRestaurant.Visible = false;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAccount.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAccount.Location = new System.Drawing.Point(131, 407);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(91, 49);
            this.btnDeleteAccount.TabIndex = 41;
            this.btnDeleteAccount.Text = "حذف حساب";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(366, 467);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.txtNameRestaurant);
            this.Controls.Add(this.lblNameRestaurant);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.TimeEnd);
            this.Controls.Add(this.lbl_last);
            this.Controls.Add(this.TimeBegin);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureProfile);
            this.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditProfile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ویرایش پروفایل";
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnDeleteAccount;
    }
}