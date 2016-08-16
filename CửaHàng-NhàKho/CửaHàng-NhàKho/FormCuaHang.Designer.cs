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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tkLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.hanghoaPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.themdsPic = new System.Windows.Forms.PictureBox();
            this.xoadsPic = new System.Windows.Forms.PictureBox();
            this.giohangPnl = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtoanBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tongtienLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xoahetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.soluongNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.slcprodLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themdsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoadsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giohangPnl)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongNum)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Location = new System.Drawing.Point(109, 28);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(187, 23);
            this.searchBox.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.searchIcon);
            this.groupBox1.Controls.Add(this.hanghoaPnl);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Controls.Add(this.tkLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 401);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng:";
            // 
            // searchIcon
            // 
            this.searchIcon.Location = new System.Drawing.Point(304, 25);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(30, 26);
            this.searchIcon.TabIndex = 7;
            this.searchIcon.TabStop = false;
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // hanghoaPnl
            // 
            this.hanghoaPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hanghoaPnl.Location = new System.Drawing.Point(6, 57);
            this.hanghoaPnl.Name = "hanghoaPnl";
            this.hanghoaPnl.Size = new System.Drawing.Size(348, 338);
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
            this.themdsPic.Click += new System.EventHandler(this.themdsPic_Click);
            // 
            // xoadsPic
            // 
            this.xoadsPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoadsPic.ImageLocation = "Resources\\signout";
            this.xoadsPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("xoadsPic.InitialImage")));
            this.xoadsPic.Location = new System.Drawing.Point(378, 103);
            this.xoadsPic.Name = "xoadsPic";
            this.xoadsPic.Size = new System.Drawing.Size(53, 53);
            this.xoadsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xoadsPic.TabIndex = 11;
            this.xoadsPic.TabStop = false;
            this.xoadsPic.Click += new System.EventHandler(this.xoadsPic_Click);
            // 
            // giohangPnl
            // 
            this.giohangPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.giohangPnl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giohangPnl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.giaban,
            this.soluong,
            this.thanhTien});
            this.giohangPnl.Location = new System.Drawing.Point(18, 22);
            this.giohangPnl.Name = "giohangPnl";
            this.giohangPnl.RowHeadersVisible = false;
            this.giohangPnl.Size = new System.Drawing.Size(414, 335);
            this.giohangPnl.TabIndex = 12;
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã";
            this.masp.Name = "masp";
            this.masp.Width = 50;
            // 
            // tensp
            // 
            this.tensp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            // 
            // giaban
            // 
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            this.giaban.Width = 70;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 50;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.Width = 70;
            // 
            // thanhtoanBtn
            // 
            this.thanhtoanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thanhtoanBtn.Location = new System.Drawing.Point(739, 419);
            this.thanhtoanBtn.Name = "thanhtoanBtn";
            this.thanhtoanBtn.Size = new System.Drawing.Size(143, 29);
            this.thanhtoanBtn.TabIndex = 13;
            this.thanhtoanBtn.Text = "Thanh toán";
            this.thanhtoanBtn.UseVisualStyleBackColor = true;
            this.thanhtoanBtn.Click += new System.EventHandler(this.thanhtoanBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tongtienLbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.giohangPnl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(437, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 392);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // tongtienLbl
            // 
            this.tongtienLbl.AutoSize = true;
            this.tongtienLbl.Location = new System.Drawing.Point(350, 360);
            this.tongtienLbl.Name = "tongtienLbl";
            this.tongtienLbl.Size = new System.Drawing.Size(16, 17);
            this.tongtienLbl.TabIndex = 14;
            this.tongtienLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng:";
            // 
            // xoahetBtn
            // 
            this.xoahetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoahetBtn.Location = new System.Drawing.Point(437, 418);
            this.xoahetBtn.Name = "xoahetBtn";
            this.xoahetBtn.Size = new System.Drawing.Size(143, 29);
            this.xoahetBtn.TabIndex = 15;
            this.xoahetBtn.Text = "Xóa giỏ hàng";
            this.xoahetBtn.UseVisualStyleBackColor = true;
            this.xoahetBtn.Click += new System.EventHandler(this.xoahetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(256, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Số lượng:";
            // 
            // soluongNum
            // 
            this.soluongNum.Location = new System.Drawing.Point(330, 424);
            this.soluongNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.soluongNum.Name = "soluongNum";
            this.soluongNum.Size = new System.Drawing.Size(42, 20);
            this.soluongNum.TabIndex = 17;
            this.soluongNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã sản phẩm đang chọn:";
            // 
            // slcprodLbl
            // 
            this.slcprodLbl.AutoSize = true;
            this.slcprodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.slcprodLbl.Location = new System.Drawing.Point(192, 424);
            this.slcprodLbl.Name = "slcprodLbl";
            this.slcprodLbl.Size = new System.Drawing.Size(16, 17);
            this.slcprodLbl.TabIndex = 19;
            this.slcprodLbl.Text = "0";
            // 
            // cuahangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 460);
            this.Controls.Add(this.slcprodLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soluongNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xoahetBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.thanhtoanBtn);
            this.Controls.Add(this.xoadsPic);
            this.Controls.Add(this.themdsPic);
            this.Controls.Add(this.groupBox1);
            this.Name = "cuahangForm";
            this.Text = "Cửa hàng";
            this.Load += new System.EventHandler(this.cuahangForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themdsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoadsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giohangPnl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label tkLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel hanghoaPnl;
        private System.Windows.Forms.PictureBox themdsPic;
        private System.Windows.Forms.PictureBox xoadsPic;
        private System.Windows.Forms.DataGridView giohangPnl;
        private System.Windows.Forms.Button thanhtoanBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button xoahetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown soluongNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tongtienLbl;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label slcprodLbl;
    }
}