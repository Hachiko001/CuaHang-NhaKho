namespace CửaHàng_NhàKho
{
    partial class nhakhoFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhakhoFrom));
            this.hanghoaPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nsxTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.svBtn = new System.Windows.Forms.Button();
            this.slTxt = new System.Windows.Forms.TextBox();
            this.gianTxt = new System.Windows.Forms.TextBox();
            this.giabTxt = new System.Windows.Forms.TextBox();
            this.tenTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.themhangPic = new System.Windows.Forms.PictureBox();
            this.xoahangPic = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.daxoaPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.restoreBtn = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themhangPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoahangPic)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // hanghoaPnl
            // 
            this.hanghoaPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hanghoaPnl.Location = new System.Drawing.Point(6, 22);
            this.hanghoaPnl.Name = "hanghoaPnl";
            this.hanghoaPnl.Size = new System.Drawing.Size(328, 408);
            this.hanghoaPnl.TabIndex = 1;
            this.hanghoaPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.hanghoaPnl_Paint);
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Chuối",
            "Táo",
            "Nho",
            "Xoài",
            "Cam",
            "Lê",
            "Dầu ăn",
            "Xà phòng",
            "Xe đạp"});
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Location = new System.Drawing.Point(34, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(151, 23);
            this.searchBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hanghoaPnl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 436);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nsxTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.svBtn);
            this.groupBox2.Controls.Add(this.slTxt);
            this.groupBox2.Controls.Add(this.gianTxt);
            this.groupBox2.Controls.Add(this.giabTxt);
            this.groupBox2.Controls.Add(this.tenTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(392, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 364);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mô tả: ";
            // 
            // nsxTxt
            // 
            this.nsxTxt.Location = new System.Drawing.Point(81, 278);
            this.nsxTxt.Name = "nsxTxt";
            this.nsxTxt.Size = new System.Drawing.Size(123, 23);
            this.nsxTxt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhà SX:";
            // 
            // svBtn
            // 
            this.svBtn.Location = new System.Drawing.Point(127, 321);
            this.svBtn.Name = "svBtn";
            this.svBtn.Size = new System.Drawing.Size(76, 29);
            this.svBtn.TabIndex = 11;
            this.svBtn.Text = "Lưu";
            this.svBtn.UseVisualStyleBackColor = true;
            this.svBtn.Click += new System.EventHandler(this.svBtn_Click);
            // 
            // slTxt
            // 
            this.slTxt.Location = new System.Drawing.Point(81, 246);
            this.slTxt.Name = "slTxt";
            this.slTxt.Size = new System.Drawing.Size(123, 23);
            this.slTxt.TabIndex = 10;
            // 
            // gianTxt
            // 
            this.gianTxt.Location = new System.Drawing.Point(81, 217);
            this.gianTxt.Name = "gianTxt";
            this.gianTxt.Size = new System.Drawing.Size(123, 23);
            this.gianTxt.TabIndex = 9;
            // 
            // giabTxt
            // 
            this.giabTxt.Location = new System.Drawing.Point(81, 188);
            this.giabTxt.Name = "giabTxt";
            this.giabTxt.Size = new System.Drawing.Size(123, 23);
            this.giabTxt.TabIndex = 8;
            // 
            // tenTxt
            // 
            this.tenTxt.Location = new System.Drawing.Point(81, 161);
            this.tenTxt.Name = "tenTxt";
            this.tenTxt.Size = new System.Drawing.Size(123, 23);
            this.tenTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giá nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // themhangPic
            // 
            this.themhangPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themhangPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themhangPic.Image = ((System.Drawing.Image)(resources.GetObject("themhangPic.Image")));
            this.themhangPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("themhangPic.InitialImage")));
            this.themhangPic.Location = new System.Drawing.Point(392, 389);
            this.themhangPic.Name = "themhangPic";
            this.themhangPic.Size = new System.Drawing.Size(53, 53);
            this.themhangPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.themhangPic.TabIndex = 9;
            this.themhangPic.TabStop = false;
            this.themhangPic.Click += new System.EventHandler(this.themhangPic_Click);
            // 
            // xoahangPic
            // 
            this.xoahangPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xoahangPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoahangPic.Image = ((System.Drawing.Image)(resources.GetObject("xoahangPic.Image")));
            this.xoahangPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("xoahangPic.InitialImage")));
            this.xoahangPic.Location = new System.Drawing.Point(473, 389);
            this.xoahangPic.Name = "xoahangPic";
            this.xoahangPic.Size = new System.Drawing.Size(53, 53);
            this.xoahangPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xoahangPic.TabIndex = 10;
            this.xoahangPic.TabStop = false;
            this.xoahangPic.Click += new System.EventHandler(this.xoahangPic_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchIcon);
            this.groupBox3.Controls.Add(this.searchBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(630, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 64);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm hàng:";
            // 
            // searchIcon
            // 
            this.searchIcon.Location = new System.Drawing.Point(191, 19);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(30, 26);
            this.searchIcon.TabIndex = 6;
            this.searchIcon.TabStop = false;
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.daxoaPnl);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(630, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 364);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đã xóa:";
            // 
            // daxoaPnl
            // 
            this.daxoaPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daxoaPnl.Location = new System.Drawing.Point(8, 22);
            this.daxoaPnl.Name = "daxoaPnl";
            this.daxoaPnl.Size = new System.Drawing.Size(238, 336);
            this.daxoaPnl.TabIndex = 1;
            // 
            // restoreBtn
            // 
            this.restoreBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.restoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreBtn.InitialImage = null;
            this.restoreBtn.Location = new System.Drawing.Point(562, 389);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(53, 53);
            this.restoreBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restoreBtn.TabIndex = 12;
            this.restoreBtn.TabStop = false;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // nhakhoFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 460);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.xoahangPic);
            this.Controls.Add(this.themhangPic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "nhakhoFrom";
            this.Text = "Nhà kho";
            this.Load += new System.EventHandler(this.nhakhoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themhangPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoahangPic)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restoreBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel hanghoaPnl;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox themhangPic;
        private System.Windows.Forms.PictureBox xoahangPic;
        private System.Windows.Forms.Button svBtn;
        private System.Windows.Forms.TextBox slTxt;
        private System.Windows.Forms.TextBox gianTxt;
        private System.Windows.Forms.TextBox giabTxt;
        private System.Windows.Forms.TextBox tenTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nsxTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel daxoaPnl;
        private System.Windows.Forms.PictureBox restoreBtn;
    }
}