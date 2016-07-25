namespace CửaHàng_NhàKho
{
    partial class nhakhoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhakhoForm));
            this.hanghoaPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tkLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.motaLbl = new System.Windows.Forms.Label();
            this.themhangPic = new System.Windows.Forms.PictureBox();
            this.xoahangPic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themhangPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoahangPic)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Chuối",
            "Táo",
            "Nho",
            "Xoài",
            "Cam",
            "Lê"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(660, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 5;
            // 
            // tkLbl
            // 
            this.tkLbl.AutoSize = true;
            this.tkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tkLbl.Location = new System.Drawing.Point(624, 26);
            this.tkLbl.Name = "tkLbl";
            this.tkLbl.Size = new System.Drawing.Size(104, 17);
            this.tkLbl.TabIndex = 6;
            this.tkLbl.Text = "Tìm kiếm hàng:";
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
            this.groupBox2.Controls.Add(this.motaLbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(392, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 150);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mô tả: ";
            // 
            // motaLbl
            // 
            this.motaLbl.AllowDrop = true;
            this.motaLbl.AutoSize = true;
            this.motaLbl.Location = new System.Drawing.Point(19, 22);
            this.motaLbl.Name = "motaLbl";
            this.motaLbl.Size = new System.Drawing.Size(43, 17);
            this.motaLbl.TabIndex = 0;
            this.motaLbl.Text = "Mô tả";
            // 
            // themhangPic
            // 
            this.themhangPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themhangPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themhangPic.Image = ((System.Drawing.Image)(resources.GetObject("themhangPic.Image")));
            this.themhangPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("themhangPic.InitialImage")));
            this.themhangPic.Location = new System.Drawing.Point(392, 179);
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
            this.xoahangPic.Location = new System.Drawing.Point(392, 238);
            this.xoahangPic.Name = "xoahangPic";
            this.xoahangPic.Size = new System.Drawing.Size(53, 53);
            this.xoahangPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xoahangPic.TabIndex = 10;
            this.xoahangPic.TabStop = false;
            this.xoahangPic.Click += new System.EventHandler(this.xoahangPic_Click);
            // 
            // nhakhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 460);
            this.Controls.Add(this.xoahangPic);
            this.Controls.Add(this.themhangPic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tkLbl);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "nhakhoForm";
            this.Text = "FormNhaKho";
            this.Load += new System.EventHandler(this.nhakhoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themhangPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoahangPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel hanghoaPnl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tkLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox themhangPic;
        private System.Windows.Forms.PictureBox xoahangPic;
        private System.Windows.Forms.Label motaLbl;
    }
}