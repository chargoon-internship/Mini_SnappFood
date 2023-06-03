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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserLogin = new System.Windows.Forms.Label();
            this.PassLogin = new System.Windows.Forms.Label();
            this.txt_userPass = new System.Windows.Forms.TextBox();
            this.txt_userLogin = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRestaurant = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.lbl_last = new System.Windows.Forms.Label();
            this.TimeEnd = new System.Windows.Forms.MaskedTextBox();
            this.TimeBegin = new System.Windows.Forms.MaskedTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(490, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "به نرم افزار اسنپ فود خوش آمدید";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnappFood.Properties.Resources.user_2_;
            this.pictureBox1.Location = new System.Drawing.Point(554, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSize = true;
            this.UserLogin.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLogin.ForeColor = System.Drawing.Color.White;
            this.UserLogin.Location = new System.Drawing.Point(427, 361);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(92, 33);
            this.UserLogin.TabIndex = 2;
            this.UserLogin.Text = "نام کاربری";
            // 
            // PassLogin
            // 
            this.PassLogin.AutoSize = true;
            this.PassLogin.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassLogin.ForeColor = System.Drawing.Color.White;
            this.PassLogin.Location = new System.Drawing.Point(444, 410);
            this.PassLogin.Name = "PassLogin";
            this.PassLogin.Size = new System.Drawing.Size(75, 33);
            this.PassLogin.TabIndex = 3;
            this.PassLogin.Text = "رمز عبور";
            // 
            // txt_userPass
            // 
            this.txt_userPass.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_userPass.Location = new System.Drawing.Point(555, 406);
            this.txt_userPass.Name = "txt_userPass";
            this.txt_userPass.Size = new System.Drawing.Size(290, 41);
            this.txt_userPass.TabIndex = 4;
            // 
            // txt_userLogin
            // 
            this.txt_userLogin.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_userLogin.Location = new System.Drawing.Point(555, 358);
            this.txt_userLogin.Name = "txt_userLogin";
            this.txt_userLogin.Size = new System.Drawing.Size(290, 41);
            this.txt_userLogin.TabIndex = 5;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignUp.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSignUp.Location = new System.Drawing.Point(556, 460);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(94, 37);
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Text = "ثبت نام";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(751, 460);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 37);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "ورود";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRestaurant
            // 
            this.buttonRestaurant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.buttonRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestaurant.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRestaurant.Location = new System.Drawing.Point(555, 454);
            this.buttonRestaurant.Name = "buttonRestaurant";
            this.buttonRestaurant.Size = new System.Drawing.Size(290, 43);
            this.buttonRestaurant.TabIndex = 8;
            this.buttonRestaurant.Text = "ثبت نام رستوران";
            this.buttonRestaurant.UseVisualStyleBackColor = false;
            this.buttonRestaurant.Click += new System.EventHandler(this.buttonRestaurant_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCustomer.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomer.Location = new System.Drawing.Point(555, 406);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(290, 43);
            this.buttonCustomer.TabIndex = 9;
            this.buttonCustomer.Text = "ثبت نام کاربر";
            this.buttonCustomer.UseVisualStyleBackColor = false;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(556, 507);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 37);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "بازگشت";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(465, 456);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(37, 33);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "نام";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(404, 503);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 33);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(555, 500);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(290, 41);
            this.txtLastName.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(424, 550);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(72, 33);
            this.lblCode.TabIndex = 14;
            this.lblCode.Text = "کد ملی";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(436, 597);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 33);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "آدرس";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(554, 453);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(290, 41);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(555, 547);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(290, 41);
            this.txtCode.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(554, 594);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 41);
            this.txtAddress.TabIndex = 18;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubmit.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(555, 676);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(290, 43);
            this.buttonSubmit.TabIndex = 19;
            this.buttonSubmit.Text = "ثبت اطلاعات";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoBack.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoBack.Location = new System.Drawing.Point(554, 725);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(290, 43);
            this.buttonGoBack.TabIndex = 20;
            this.buttonGoBack.Text = "بازگشت";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_last.ForeColor = System.Drawing.Color.White;
            this.lbl_last.Location = new System.Drawing.Point(684, 641);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(27, 33);
            this.lbl_last.TabIndex = 22;
            this.lbl_last.Text = "تا";
            // 
            // TimeEnd
            // 
            this.TimeEnd.Location = new System.Drawing.Point(749, 643);
            this.TimeEnd.Mask = "00:00";
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(95, 27);
            this.TimeEnd.TabIndex = 23;
            this.TimeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeEnd.ValidatingType = typeof(System.DateTime);
            // 
            // TimeBegin
            // 
            this.TimeBegin.Location = new System.Drawing.Point(555, 643);
            this.TimeBegin.Mask = "00:00";
            this.TimeBegin.Name = "TimeBegin";
            this.TimeBegin.Size = new System.Drawing.Size(95, 27);
            this.TimeBegin.TabIndex = 24;
            this.TimeBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBegin.ValidatingType = typeof(System.DateTime);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(397, 641);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 33);
            this.lblTime.TabIndex = 25;
            this.lblTime.Text = "ساعت کار کرد";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.TimeBegin);
            this.Controls.Add(this.TimeEnd);
            this.Controls.Add(this.lbl_last);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonRestaurant);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.PassLogin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userPass);
            this.Controls.Add(this.txt_userLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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