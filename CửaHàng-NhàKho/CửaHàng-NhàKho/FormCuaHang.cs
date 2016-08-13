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
    public partial class cuahangForm : Form
    {
        //---------------------- khai báo các biến cục bộ
        private List<HangHoa> listHang = new List<HangHoa>();
        HangHoa selectedProd;
        string connectStr = "Integrated Security=SSPI;Server=GILLET;Database=QUAN_LY_CUA_HANG";

        private bool tooltipused = false;
        private ToolTip tooltip = new ToolTip();

        float tongtien;

        //---------------------------- khởi tạo from cửa hàng
        public cuahangForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormClosing += new FormClosingEventHandler(CuaHang_Close);
        }

        //-------------------------- khi nhấn nút thoát form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (cuahangForm_Close() == false)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Xuất thông báo, chờ người dùng xác nhận đóng chương trình
        /// </summary>
        /// <returns>
        /// true nếu chọn yes và false nếu chọn No
        /// </returns>
        private bool cuahangForm_Close()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// tải thông tin mặt hàng trong sql server và lưu vào biến cục bộ listHang
        /// </summary>
        private void taiCSDL()
        {
            listHang.Clear();                   // xóa list hàng đang có để tải lại
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
            catch (InvalidCastException)
            {
                MessageBox.Show("Lỗi convert", "Thông báo lỗi");
            }
            ketnoi.Close();
        }
        /// <summary>
        /// Xóa các mặt hàng trong listHang. Dùng để cập nhật lại menu khi  có thêm mặt hàng hoặc sự thay đổi từ kho hàng
        /// </summary>
        private void clearFlowPanel()
        {
            List<Control> listControls = hanghoaPnl.Controls.Cast<Control>().ToList();

            foreach (Control control in listControls)
            {
                hanghoaPnl.Controls.Remove(control);
                control.Dispose();
            }
        }
        /// <summary>
        /// cập nhật lại danh sách hàng
        /// </summary>
        private void capnhatHangHoa()
        {
            clearFlowPanel();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (HangHoa A in listHang)
            {
                PictureBox newBox = new PictureBox();
                newBox.Size = new System.Drawing.Size(100, 94);
                newBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newBox.ImageLocation = A.Hinhanh;

                // thêm điều khiển cho box
                newBox.MouseHover += new EventHandler(picHang_Hover);
                newBox.MouseClick += new MouseEventHandler(picHang_Click);
                newBox.Tag = A.Mahang;
                newBox.Name = A.Mahang;
                hanghoaPnl.Controls.Add(newBox);
                source.Add(A.Mahang);
                source.Add(A.Ten);
            }
            searchBox.AutoCompleteCustomSource = source;
        }

        private void tinhTongTien()
        {
            float sum = 0;
            for (int i = 0; i < giohangPnl.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(giohangPnl.Rows[i].Cells[4].Value);
            }
            tongtienLbl.Text = sum.ToString();
            tongtien = sum;
        }

        /// <summary>
        /// các bước khi tải cuahangForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cuahangForm_Load(object sender, EventArgs e)
        {
            taiCSDL();
            capnhatHangHoa();
            searchIcon.ImageLocation = "Resources\\searchicon.png";
            searchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            themdsPic.ImageLocation = "Resources\\addtocart.png";
            xoadsPic.ImageLocation = "Resources\\trashcan.png";
            giohangPnl.RowHeadersVisible = false;
            soluongNum.Minimum = 0;
            searchBox.KeyDown += new KeyEventHandler(searchBox_KeyDown);
        }

        //----------------------- cài đặt cho hình ảnh hàng hóa
        // khi để chuột lên pic hàng
        private void picHang_Hover(object sender, EventArgs e)
        {
            // làm gì đó
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
            foreach (HangHoa temp in listHang)
            {
                if (temp.Mahang == picBox.Tag.ToString())
                {
                    selectedProd = temp;
                    soluongNum.Maximum = selectedProd.Soluong;
                    slcprodLbl.Text = selectedProd.Mahang;
                    break;
                }
            }

        }

        //------------------------ cài đặt thêm và xóa hàng
        private void themdsPic_Click(object sender, EventArgs e)
        {
            try
            {
                if (soluongNum.Value <= 0)
                    throw new InvalidOperationException("Số lượng chưa xác định");
                float thanhtien = selectedProd.Giaban * Convert.ToSingle(soluongNum.Value);
                giohangPnl.Rows.Add(selectedProd.Mahang, selectedProd.Ten, selectedProd.Giaban, soluongNum.Value, thanhtien);
                tinhTongTien();
                soluongNum.ResetText();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Số lượng chưa xác định", "Lỗi");
            }
          }

        private void xoadsPic_Click(object sender, EventArgs e)
        {
            try
            {
                giohangPnl.Rows.RemoveAt(giohangPnl.CurrentRow.Index);
                tinhTongTien();
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Ô trống, không thể xóa", "Thông báo lỗi");
            }
        }

        private void xoahetBtn_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn xóa danh sách hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                giohangPnl.Rows.Clear();
                tinhTongTien();
            }
            else
            {
                //do nothing
            }
        }

        //----------------------------------------- cài đặt cho ô tìm kiếm
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchIcon_Click(this, new EventArgs());
            }
        }
        private void searchIcon_Click(object sender, EventArgs e)
        {
            foreach (HangHoa a in listHang)
            {
                if (a.Mahang == searchBox.Text || a.Ten == searchBox.Text)
                {
                    selectedProd = a;
                    slcprodLbl.Text = selectedProd.Mahang;
                }
            }
        }

        //----------------- cài đặt nút thanh toán

        private void thanhtoanBtn_Click(object sender, EventArgs e)
        {
            int maHDLN = 0;
            try
            {
                SqlConnection ketnoi = new SqlConnection(connectStr);
                ketnoi.Open();

                // lấy mahd lớn nhất để tạo mã hd tiếp theo
                SqlCommand lenhSQL = new SqlCommand();
                lenhSQL.Connection = ketnoi;
                lenhSQL.CommandText = "SELECT MAX(MAHD) as prevMAHD FROM HOADON";
                lenhSQL.CommandType = CommandType.Text;

                lenhSQL.ExecuteNonQuery();
                SqlDataReader reader = lenhSQL.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        maHDLN = Convert.ToInt32(reader.GetString(0));
                    }
                }
                reader.Close();
                // thêm 1 giá trị cho mã hóa đơn
                maHDLN++;
                // lấy thời gian hiện tại
                string time = DateTime.Now.ToString("MM/dd/yyyy");
                // thiết lập câu lệnh thêm mã hóa đơn
                lenhSQL.CommandText = "INSERT HOADON VALUES('" + maHDLN + "','CH00001','" + time + "',"+tongtien+")";
                lenhSQL.CommandType = CommandType.Text;
                lenhSQL.ExecuteNonQuery();

                for (int i = 0; i < giohangPnl.Rows.Count-1; ++i)
                {
                    lenhSQL.CommandText =
                        "INSERT CT_HOADON VALUES('" + maHDLN + "','" + giohangPnl.Rows[i].Cells[0].Value.ToString() + "','" + giohangPnl.Rows[i].Cells[3].Value.ToString() + "')";
                    lenhSQL.ExecuteNonQuery();
                }

                ketnoi.Close();
            }
            catch (System.Configuration.ConfigurationException)
            {
                MessageBox.Show("Không thể kết nối vào cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Câu truy cứu sai", "Thông báo lỗi");
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Lỗi convert", "Thông báo lỗi");
            }
            MessageBox.Show("Thanh toán thành công", "Thông báo");
        }
    }
}
