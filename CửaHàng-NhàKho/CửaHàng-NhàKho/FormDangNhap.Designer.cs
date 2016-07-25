namespace CửaHàng_NhàKho
{
    partial class FormDangNhap
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
            this.chBtn = new System.Windows.Forms.Button();
            this.nkBtn = new System.Windows.Forms.Button();
            this.dangnhapPnl = new System.Windows.Forms.Panel();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dangnhapPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // chBtn
            // 
            this.chBtn.BackColor = System.Drawing.Color.Tomato;
            this.chBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chBtn.Location = new System.Drawing.Point(12, 24);
            this.chBtn.Name = "chBtn";
            this.chBtn.Size = new System.Drawing.Size(361, 113);
            this.chBtn.TabIndex = 0;
            this.chBtn.Text = "Cửa Hàng";
            this.chBtn.UseVisualStyleBackColor = false;
            this.chBtn.Click += new System.EventHandler(this.chBtn_Click);
            // 
            // nkBtn
            // 
            this.nkBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.nkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nkBtn.Location = new System.Drawing.Point(517, 24);
            this.nkBtn.Name = "nkBtn";
            this.nkBtn.Size = new System.Drawing.Size(361, 113);
            this.nkBtn.TabIndex = 1;
            this.nkBtn.Text = "Nhà Kho";
            this.nkBtn.UseVisualStyleBackColor = false;
            this.nkBtn.Click += new System.EventHandler(this.nkBtn_Click);
            // 
            // dangnhapPnl
            // 
            this.dangnhapPnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dangnhapPnl.Controls.Add(this.BtnDangNhap);
            this.dangnhapPnl.Controls.Add(this.txtPass);
            this.dangnhapPnl.Controls.Add(this.txtID);
            this.dangnhapPnl.Controls.Add(this.label2);
            this.dangnhapPnl.Controls.Add(this.label1);
            this.dangnhapPnl.Location = new System.Drawing.Point(268, 195);
            this.dangnhapPnl.Name = "dangnhapPnl";
            this.dangnhapPnl.Size = new System.Drawing.Size(381, 168);
            this.dangnhapPnl.TabIndex = 2;
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnDangNhap.Location = new System.Drawing.Point(217, 105);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(124, 37);
            this.BtnDangNhap.TabIndex = 4;
            this.BtnDangNhap.Text = "Đăng nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(144, 79);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(169, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(144, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 20);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(72, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.BtnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 430);
            this.Controls.Add(this.dangnhapPnl);
            this.Controls.Add(this.nkBtn);
            this.Controls.Add(this.chBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.dangnhapPnl.ResumeLayout(false);
            this.dangnhapPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chBtn;
        private System.Windows.Forms.Button nkBtn;
        private System.Windows.Forms.Panel dangnhapPnl;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDangNhap;
    }
}

