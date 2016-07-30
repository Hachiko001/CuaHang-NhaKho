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
    public partial class nhakhoForm : Form
    {
        List<HangHoa> listHang = new List<HangHoa>();
        HangHoa selectedProd;

        private bool tooltipused = false;
        private ToolTip tooltip = new ToolTip();
        PictureBox themHang = new PictureBox();
        int i = 0;
        public nhakhoForm()
        {
            InitializeComponent();
            
        }

        private void taiCSDL()
        {
            string connectStr = null;
            connectStr = "Integrated Security=SSPI;Server=(localdb)\\COMPUTER;Database=QUAN_LY_CUA_HANG";
            // Tạo kết nối đến sql server
            SqlConnection ketnoi = new SqlConnection(connectStr);
            try
            {
                ketnoi.Open();
            }
            catch (System.Configuration.ConfigurationException ex)
            {
                MessageBox.Show("Không thể kết nối vào cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // gắn kết nối cho lenhSQL
            SqlCommand lenhSQL = new SqlCommand();
            lenhSQL.Connection = ketnoi;
            lenhSQL.CommandText = "SELECT * FROM SANPHAM";
            lenhSQL.CommandType = CommandType.Text;
            try
            {
                lenhSQL.ExecuteNonQuery();
                SqlDataReader reader = lenhSQL.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HangHoa A = new HangHoa();
                        A.Mahang = reader.GetString(0);
                        A.Ten = reader.GetString(1);
                        A.Soluong = reader.GetInt32(2);
                        A.Giaban = Convert.ToSingle(reader.GetValue(3));
                        A.Gianhap = Convert.ToSingle(reader.GetValue(4));
                        A.Nhasx = reader.GetString(5);
                        A.Hinhanh = "Resources//Hanghoa//" + A.Mahang + ".jpg";
                        listHang.Add(A);
                        MessageBox.Show(A.Ten + ".jpg", "Text");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Tải thất bại", "Thông báo lỗi");
            }
            catch(InvalidCastException)
            {
                MessageBox.Show("Lỗi convert", "Thông báo lỗi");
            }
        }

        private void capnhatHangHoa()
        {
            foreach(HangHoa A in listHang)
            {
                PictureBox newBox = new PictureBox();
                newBox.Size = new System.Drawing.Size(100, 94);
                newBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newBox.ImageLocation = A.Hinhanh;
                MessageBox.Show(newBox.ImageLocation, "Text");
                newBox.MouseHover += new EventHandler(picHang_Hover);
                newBox.MouseLeave += new EventHandler(picHang_Leave);
                newBox.MouseClick += new MouseEventHandler(picHang_Click);
                newBox.MouseDoubleClick += new MouseEventHandler(picHang_DoubleClick);
                newBox.Tag = A.Mahang;
                hanghoaPnl.Controls.Add(newBox);
                
            }
        }


        private void NhaKho_Close(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //khong lam gi ca
            }
        }

        private void nhakhoForm_Load(object sender, EventArgs e)
        {
            taiCSDL();
            capnhatHangHoa();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += new FormClosingEventHandler(NhaKho_Close);

            themhangPic.ImageLocation = "Resources\\add.png";
            xoahangPic.ImageLocation = "Resources\\minus.png";
            themhangPic.MouseHover += new EventHandler(themhangPic_Hover);
            themhangPic.MouseLeave += new EventHandler(themhangPic_Leave);
            motaLbl.MaximumSize = new Size(170, 130);

        }
        


        private void hanghoaPnl_Paint(object sender, PaintEventArgs e)
        {
            hanghoaPnl.AutoScroll = true;
        }

        // cài đặt cho hình ảnh hàng hóa
        private void picHang_Hover(object sender,EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            picBox.ImageLocation = "Resources//addsign2.png";
        }
        private void picHang_Leave(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            string direc = "Resources//Hanghoa//" + picBox.Tag + ".jpg";
            picBox.Image = Image.FromFile(direc);
        }
        private void picHang_Click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;

            picBox.BorderStyle = BorderStyle.FixedSingle;
        }
        private void picHang_DoubleClick(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            picBox.ImageLocation = "Resources//addsign2.png";
        }


        // cài đặt cho nút thêm hàng
        private void themhangPic_Click(object sender, EventArgs e)
        {
            Form chitiethangForm = new chitiethangForm(this);
            chitiethangForm.Show();
            
        }
        private void themhangPic_Hover(object sender, EventArgs e)
        {
            if (tooltipused == false)
            {
                tooltip.Show("Chọn/Thay đổi hình ảnh", themhangPic);
                tooltipused = true;
            }
        }
        private void themhangPic_Leave(object sender, EventArgs e)
        {
            tooltip.Hide(themhangPic);
            tooltipused = false;
        }


        // cài đặt nút xóa hàng
        private void xoahangPic_Click(object sender, EventArgs e)
        {

        }
    }
}
