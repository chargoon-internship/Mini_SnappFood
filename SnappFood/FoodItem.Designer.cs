namespace SnappFood
{
    partial class FoodItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foodName = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.PictureBox();
            this.lbl_exist = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.TextBox();
            this.lbl_toman = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnappFood.Properties.Resources.dinner;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // foodName
            // 
            this.foodName.AutoSize = true;
            this.foodName.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foodName.ForeColor = System.Drawing.Color.Black;
            this.foodName.Location = new System.Drawing.Point(226, 38);
            this.foodName.Name = "foodName";
            this.foodName.Size = new System.Drawing.Size(194, 46);
            this.foodName.TabIndex = 1;
            this.foodName.Text = "چلو جوجه کباب";
            // 
            // removeButton
            // 
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Image = global::SnappFood.Properties.Resources.negative;
            this.removeButton.Location = new System.Drawing.Point(1142, 38);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(51, 44);
            this.removeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeButton.TabIndex = 2;
            this.removeButton.TabStop = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Image = global::SnappFood.Properties.Resources.positive;
            this.addButton.Location = new System.Drawing.Point(1282, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(51, 44);
            this.addButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addButton.TabIndex = 3;
            this.addButton.TabStop = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lbl_exist
            // 
            this.lbl_exist.AutoSize = true;
            this.lbl_exist.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_exist.Location = new System.Drawing.Point(474, 42);
            this.lbl_exist.Name = "lbl_exist";
            this.lbl_exist.Size = new System.Drawing.Size(97, 38);
            this.lbl_exist.TabIndex = 4;
            this.lbl_exist.Text = " تمام شد";
            this.lbl_exist.Visible = false;
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.counter.Location = new System.Drawing.Point(1199, 46);
            this.counter.Name = "counter";
            this.counter.ReadOnly = true;
            this.counter.Size = new System.Drawing.Size(77, 36);
            this.counter.TabIndex = 5;
            this.counter.Text = "0";
            this.counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_toman
            // 
            this.lbl_toman.AutoSize = true;
            this.lbl_toman.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_toman.Location = new System.Drawing.Point(955, 52);
            this.lbl_toman.Name = "lbl_toman";
            this.lbl_toman.Size = new System.Drawing.Size(49, 28);
            this.lbl_toman.TabIndex = 6;
            this.lbl_toman.Text = "تومان";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.Location = new System.Drawing.Point(1010, 49);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(48, 33);
            this.lbl_price.TabIndex = 7;
            this.lbl_price.Text = "1000";
            // 
            // FoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_toman);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.lbl_exist);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.foodName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FoodItem";
            this.Size = new System.Drawing.Size(1350, 125);
            this.Load += new System.EventHandler(this.FoodItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox removeButton;
        private PictureBox addButton;
        private TextBox counter;
        public Label foodName;
        public Label lbl_exist;
        private Label lbl_toman;
        private Label lbl_price;
    }
}
