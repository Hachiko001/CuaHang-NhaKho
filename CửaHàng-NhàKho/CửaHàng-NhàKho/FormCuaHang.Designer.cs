namespace CửaHàng_NhàKho
{
    partial class cuahangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuahangForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tkLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hanghoaPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.themdsPic = new System.Windows.Forms.PictureBox();
            this.xoadsPic = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thanhtoanBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themdsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoadsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 23);
            this.textBox1.TabIndex = 0;
            // 
            // tkLbl
            // 
            this.tkLbl.AutoSize = true;
            this.tkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tkLbl.Location = new System.Drawing.Point(6, 28);
            this.tkLbl.Name = "tkLbl";
            this.tkLbl.Size = new System.Drawing.Size(108, 17);
            this.tkLbl.TabIndex = 1;
            this.tkLbl.Text = "Tìm kiếm hàng: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hanghoaPnl);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tkLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 436);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng:";
            // 
            // hanghoaPnl
            // 
            this.hanghoaPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hanghoaPnl.Location = new System.Drawing.Point(6, 57);
            this.hanghoaPnl.Name = "hanghoaPnl";
            this.hanghoaPnl.Size = new System.Drawing.Size(328, 363);
            this.hanghoaPnl.TabIndex = 1;
            // 
            // themdsPic
            // 
            this.themdsPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themdsPic.Image = ((System.Drawing.Image)(resources.GetObject("themdsPic.Image")));
            this.themdsPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("themdsPic.InitialImage")));
            this.themdsPic.Location = new System.Drawing.Point(378, 44);
            this.themdsPic.Name = "themdsPic";
            this.themdsPic.Size = new System.Drawing.Size(53, 53);
            this.themdsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.themdsPic.TabIndex = 10;
            this.themdsPic.TabStop = false;
            // 
            // xoadsPic
            // 
            this.xoadsPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoadsPic.ImageLocation = "Resources\\signout";
            this.xoadsPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("xoadsPic.InitialImage")));
            this.xoadsPic.Location = new System.Drawing.Point(378, 276);
            this.xoadsPic.Name = "xoadsPic";
            this.xoadsPic.Size = new System.Drawing.Size(53, 53);
            this.xoadsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xoadsPic.TabIndex = 11;
            this.xoadsPic.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 285);
            this.dataGridView1.TabIndex = 12;
            // 
            // thanhtoanBtn
            // 
            this.thanhtoanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thanhtoanBtn.Location = new System.Drawing.Point(738, 418);
            this.thanhtoanBtn.Name = "thanhtoanBtn";
            this.thanhtoanBtn.Size = new System.Drawing.Size(143, 29);
            this.thanhtoanBtn.TabIndex = 13;
            this.thanhtoanBtn.Text = "Thanh toán";
            this.thanhtoanBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(437, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 326);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // cuahangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.thanhtoanBtn);
            this.Controls.Add(this.xoadsPic);
            this.Controls.Add(this.themdsPic);
            this.Controls.Add(this.groupBox1);
            this.Name = "cuahangForm";
            this.Text = "FormCuaHang";
            this.Load += new System.EventHandler(this.cuahangForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themdsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoadsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tkLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel hanghoaPnl;
        private System.Windows.Forms.PictureBox themdsPic;
        private System.Windows.Forms.PictureBox xoadsPic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button thanhtoanBtn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}