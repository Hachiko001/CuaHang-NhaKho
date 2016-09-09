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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.csdlTxt = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dangnhapPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // chBtn
            // 
            this.chBtn.BackColor = System.Drawing.Color.Tomato;
            this.chBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chBtn.Location = new System.Drawing.Point(16, 30);
            this.chBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBtn.Name = "chBtn";
            this.chBtn.Size = new System.Drawing.Size(481, 139);
            this.chBtn.TabIndex = 0;
            this.chBtn.Text = "Cửa Hàng";
            this.chBtn.UseVisualStyleBackColor = false;
            this.chBtn.Click += new System.EventHandler(this.chBtn_Click);
            // 
            // nkBtn
            // 
            this.nkBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.nkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nkBtn.Location = new System.Drawing.Point(689, 30);
            this.nkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nkBtn.Name = "nkBtn";
            this.nkBtn.Size = new System.Drawing.Size(481, 139);
            this.nkBtn.TabIndex = 1;
            this.nkBtn.Text = "Nhà Kho";
            this.nkBtn.UseVisualStyleBackColor = false;
            this.nkBtn.Click += new System.EventHandler(this.nkBtn_Click);
            // 
            // dangnhapPnl
            // 
            this.dangnhapPnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dangnhapPnl.Controls.Add(this.label3);
            this.dangnhapPnl.Controls.Add(this.BtnDangNhap);
            this.dangnhapPnl.Controls.Add(this.csdlTxt);
            this.dangnhapPnl.Controls.Add(this.txtPass);
            this.dangnhapPnl.Controls.Add(this.txtID);
            this.dangnhapPnl.Controls.Add(this.label2);
            this.dangnhapPnl.Controls.Add(this.label1);
            this.dangnhapPnl.Location = new System.Drawing.Point(357, 240);
            this.dangnhapPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dangnhapPnl.Name = "dangnhapPnl";
            this.dangnhapPnl.Size = new System.Drawing.Size(508, 247);
            this.dangnhapPnl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên cơ sở dữ liệu";
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnDangNhap.Location = new System.Drawing.Point(293, 182);
            this.BtnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(165, 46);
            this.BtnDangNhap.TabIndex = 4;
            this.BtnDangNhap.Text = "Đăng nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // csdlTxt
            // 
            this.csdlTxt.Location = new System.Drawing.Point(192, 139);
            this.csdlTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.csdlTxt.Name = "csdlTxt";
            this.csdlTxt.Size = new System.Drawing.Size(224, 22);
            this.csdlTxt.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(192, 95);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(224, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(192, 47);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(224, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(96, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(840, 502);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "(*)Để trống tên CSDL để chọn máy tính đang chạy";
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.BtnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 529);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dangnhapPnl);
            this.Controls.Add(this.nkBtn);
            this.Controls.Add(this.chBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.dangnhapPnl.ResumeLayout(false);
            this.dangnhapPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox csdlTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

