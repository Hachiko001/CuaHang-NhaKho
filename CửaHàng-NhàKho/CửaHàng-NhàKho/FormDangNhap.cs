using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CửaHàng_NhàKho
{
    public partial class FormDangNhap : Form
    {
        int formSelected = 0;
        string id;
        string password;
        public FormDangNhap()
        {
            InitializeComponent();
            dangnhapPnl.Visible = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void chBtn_Click(object sender, EventArgs e)
        {
            formSelected = 1; //cua hang da duoc chon
            nkBtn.BackColor = Color.ForestGreen;    //reset mau cho nkBtn
            chBtn.BackColor = Color.OrangeRed;         // chọn màu mới cho chBtn
            dangnhapPnl.Visible = true;
        }

        private void nkBtn_Click(object sender, EventArgs e)
        {
            formSelected = 0;                       //nha kho da duoc chon
            chBtn.BackColor = Color.Tomato;         // reset chBtn
            nkBtn.BackColor = Color.DarkGreen;      // chọn màu cho nkBtn
            dangnhapPnl.Visible = true;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (id == "admin" && password == "admin")
            {
                if (formSelected == 0)
                {
                    Form nkForm = new nhakhoFrom();
                    nkForm.Show();
                    this.Hide();
                }
                else
                {
                    Form chForm = new cuahangForm();
                    chForm.Show();
                    this.Hide();
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            id = objTextBox.Text;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            TextBox objTextBox = (TextBox)sender;
            password = objTextBox.Text;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
