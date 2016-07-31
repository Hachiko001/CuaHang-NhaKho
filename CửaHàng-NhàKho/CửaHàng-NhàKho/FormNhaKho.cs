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
    public partial class nhakhoFrom : Form
    {
        List<HangHoa> listHang = new List<HangHoa>();
        HangHoa selectedProd;

        private bool tooltipused = false;
        private ToolTip tooltip = new ToolTip();
        PictureBox themHang = new PictureBox();
        public nhakhoFrom()
        {
            InitializeComponent();
            
        }

        private void taiCSDL()
        {
            listHang.Clear();                   // xóa list hàng đang có để tải lại

            string connectStr = null;
            connectStr = "Integrated Security=SSPI;Server=GILLET;Database=QUAN_LY_CUA_HANG";
            // Tạo kết nối đến sql server
            SqlConnection ketnoi = new SqlConnection(connectStr);
            try
            {
                ketnoi.Open();
            }
            catch (System.Configuration.ConfigurationException )
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
            ketnoi.Close();
        }

        private void clearFlowPanel()
        {
            List<Control> listControls = hanghoaPnl.Controls.Cast<Control>().ToList();

            foreach (Control control in listControls)
            {
                hanghoaPnl.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void capnhatHangHoa()
        {
            clearFlowPanel();
            foreach(HangHoa A in listHang)
            {
                PictureBox newBox = new PictureBox();
                newBox.Size = new System.Drawing.Size(100, 94);
                newBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                newBox.ImageLocation = A.Hinhanh;
   
                // thêm điều khiển cho box
                newBox.MouseHover += new EventHandler(picHang_Hover);
                newBox.MouseLeave += new EventHandler(picHang_Leave);
                newBox.MouseClick += new MouseEventHandler(picHang_Click);
                newBox.MouseDoubleClick += new MouseEventHandler(picHang_DoubleClick);
                newBox.Tag = A.Mahang;
                newBox.Name = A.Mahang;
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
            xoahangPic.MouseHover += new EventHandler(xoahangPic_Hover);
            xoahangPic.MouseLeave += new EventHandler(xoahangPic_Leave);

        }
        


        private void hanghoaPnl_Paint(object sender, PaintEventArgs e)
        {
            hanghoaPnl.AutoScroll = true;
        }

        //----------------------- cài đặt cho hình ảnh hàng hóa
        // khi để chuột lên pic hàng
        private void picHang_Hover(object sender,EventArgs e)
        {
            // làm gì đó
        }
        // chỉnh lại về hình của mặt hàng
        private void picHang_Leave(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            string direc = "Resources//Hanghoa//" + picBox.Tag + ".jpg";
            picBox.Image = Image.FromFile(direc);
        }


        // thay đổi khung viền của hình khi nhân và xóa khung viên của mặt hàng trước đó
        private void picHang_Click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            picBox.BorderStyle = BorderStyle.FixedSingle;

            // xóa viền mặt hàng đã chọn trước đó
            if (selectedProd != null)
            {

                PictureBox a;                                          // picbox lưu tạm
                    
                if (hanghoaPnl.Controls.ContainsKey(selectedProd.Mahang))
                {
                    a = (PictureBox)hanghoaPnl.Controls[selectedProd.Mahang];
                    a.BorderStyle = BorderStyle.None;
                }
            }

            // tạo viền cho mặt hàng đã chọn, lấy giá trị của mặt hàng vào trong selectedProd để điền vào ô mô tả
            foreach ( HangHoa temp in listHang)
            {
                if(temp.Mahang == picBox.Tag.ToString())
                {
                    selectedProd = temp;
                    break;
                }
            }
            //MessageBox.Show("Clicked");
            pictureBox1.ImageLocation = selectedProd.Hinhanh;
            //maTxt.Text = selectedProd.Mahang;
            tenTxt.Text = selectedProd.Ten;
            giabTxt.Text = selectedProd.Giaban.ToString();
            gianTxt.Text = selectedProd.Giaban.ToString();
            slTxt.Text = selectedProd.Soluong.ToString();
            nsxTxt.Text = selectedProd.Nhasx;

        }
        private void picHang_DoubleClick(object sender, EventArgs e)
        {
            
            
        }


        //----------------------------------- cài đặt cho nút thêm hàng
        private void themhangPic_Click(object sender, EventArgs e)
        {
            Form chitiethangForm = new chitiethangForm(this);
            chitiethangForm.Show();
            
        }
        private void themhangPic_Hover(object sender, EventArgs e)
        {
            if (tooltipused == false)
            {
                tooltip.Show("Thêm mặt hàng", themhangPic);
                tooltipused = true;
            }
        }
        private void themhangPic_Leave(object sender, EventArgs e)
        {
            tooltip.Hide(themhangPic);
            tooltipused = false;
        }


        //------------------------------------ cài đặt nút xóa hàng
        private void xoahangPic_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa mặt hàng " + selectedProd.Ten + " ?", "Xác nhận", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                string connectStr = null;
                connectStr = "Integrated Security=SSPI;Server=GILLET;Database=QUAN_LY_CUA_HANG";
                // Tạo kết nối đến sql server
                SqlConnection ketnoi = new SqlConnection(connectStr);
                try
                {
                    ketnoi.Open();
                }
                catch (System.Configuration.ConfigurationException)
                {
                    MessageBox.Show("Không thể kết nối vào cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                SqlCommand update = new SqlCommand();
                // câu lệnh xóa mặt hàng đang chọn
                update.CommandText = "DELETE SANPHAM WHERE MASP='" + selectedProd.Mahang + "';";
                update.Connection = ketnoi;
                update.CommandType = CommandType.Text;
                try
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show("Xóa hàng thành công");
                    taiCSDL();
                    capnhatHangHoa();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được thông tin sản phẩm");
                }
                ketnoi.Close();
            }
            else
            {
                // do something
            }
        }
        private void xoahangPic_Hover(object sender, EventArgs e)
        {
            if (tooltipused == false)
            {
                tooltip.Show("Xóa mặt hàng", themhangPic);
                tooltipused = true;
            }
        }
        private void xoahangPic_Leave(object sender, EventArgs e)
        {
            tooltip.Hide(themhangPic);
            tooltipused = false;
        }


        //----------------------------------------- cài đặt nút lưu thông tin mặt hàng để thay đổi thông tin sản phẩm ngay trên giao diện

        private void svBtn_Click(object sender, EventArgs e)
        {
            string connectStr = null;
            connectStr = "Integrated Security=SSPI;Server=GILLET;Database=QUAN_LY_CUA_HANG";
            // Tạo kết nối đến sql server
            SqlConnection ketnoi = new SqlConnection(connectStr);
            try
            {
                ketnoi.Open();
            }
            catch (System.Configuration.ConfigurationException)
            {
                MessageBox.Show("Không thể kết nối vào cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            SqlCommand update = new SqlCommand();
            // câu lệnh cập nhật thông tin mặt hàng
            update.CommandText = "UPDATE SANPHAM SET TENSP='" + tenTxt.Text + "',SOLUONG='" + slTxt.Text + "',GIABAN='" + giabTxt.Text + "',GIANHAP='" + gianTxt.Text + "',NHASX='" + 
                nsxTxt.Text + "' WHERE MASP='"+selectedProd.Mahang+"';";
            update.Connection = ketnoi;
            update.CommandType = CommandType.Text;
            try
            {
                update.ExecuteNonQuery();
                MessageBox.Show("Thêm hàng thành công");
                // cập nhật lại cơ sở dữ liệu
                taiCSDL();
                capnhatHangHoa();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được thông tin sản phẩm");
            }
            ketnoi.Close();
        }

    }
}
