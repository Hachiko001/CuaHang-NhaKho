using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            try
            {
                if (csdlTxt == null)
                {
                    throw new InvalidProgramException();
                }
            }
            catch (InvalidProgramException)
            {
                MessageBox.Show("Chưa nhập cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OKCancel);
            }

            try
            {
                // thử kết nối vào csdl
                string connectStr = "Integrated Security=SSPI;Server=" + csdlTxt.Text + ";Database=QUAN_LY_CUA_HANG";

                SqlConnection ketnoi = new SqlConnection(connectStr);

                ketnoi.Open();

                if (id == "admin" && password == "admin")
                {
                    if (formSelected == 0)
                    {
                        Form nkForm = new nhakhoFrom(csdlTxt.Text);
                        nkForm.Show();
                        // this.Close();
                        this.Hide();
                    }
                    else
                    {
                        Form chForm = new cuahangForm(csdlTxt.Text);
                        chForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    throw new InvalidExpressionException();
                }
                // đóng kết nối nếu kết nối thành công
                ketnoi.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Cơ sở dữ liệu không kết nối được hoặc không tồn tại", "Thông báo", MessageBoxButtons.OKCancel);
            }
            catch(InvalidExpressionException)
            {
                MessageBox.Show("Tài khoản/ mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK);
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

        private void OnTestTextBoxGotFocus(object sender, EventArgs e)
        {
            if (csdlTxt.Text.Equals("Nhập tên csdl", StringComparison.OrdinalIgnoreCase))
            {
                csdlTxt.Text = string.Empty;
            }
        }

        private void OnTestTextBoxLostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(csdlTxt.Text))
            {
                csdlTxt.Text = "Nhập tên csdl";
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            dangnhapPnl.Visible = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            csdlTxt.GotFocus += OnTestTextBoxGotFocus;
            csdlTxt.LostFocus += OnTestTextBoxLostFocus;

        }
    }
}
