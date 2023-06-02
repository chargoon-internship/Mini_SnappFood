namespace SnappTest
{
    partial class Form1
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
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(222, 131);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(300, 22);
            this.txt2.TabIndex = 0;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(222, 194);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(300, 22);
            this.txt3.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(222, 70);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(300, 22);
            this.txt1.TabIndex = 2;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(222, 258);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(300, 22);
            this.txt4.TabIndex = 3;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(222, 322);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(300, 22);
            this.txt5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button button1;
    }
}

