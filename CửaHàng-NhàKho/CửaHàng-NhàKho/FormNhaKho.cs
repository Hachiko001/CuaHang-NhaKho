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
using System.IO;

namespace CửaHàng_NhàKho
{
    public partial class nhakhoFrom : Form
    {
        List<HangHoa> listHang = new List<HangHoa>();
        HangHoa selectedProd;
        string connectStr = null;
        string dbname = null;
        private bool tooltipused = false;
        private ToolTip tooltip = new ToolTip();
        PictureBox themHang = new PictureBox();
        public nhakhoFrom(string csdlTen)
        {
            InitializeComponent();
            dbname = csdlTen;
            connectStr = "Integrated Security=SSPI;Server=" + csdlTen + ";Database=QUAN_LY_CUA_HANG";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (nhakhoForm_Close() == false)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private bool nhakhoForm_Close()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
                        try {
                            A.Nhasx = reader.GetString(5);
                        }
                        catch(System.Data.SqlTypes.SqlNullValueException)
                        {
                            A.Nhasx = null;
                        }
                        
                        A.TinhTrang = reader.GetInt32(6);
                        string hinhanhDir = "Resources//Hanghoa//" + A.Mahang + ".jpg";
                        string hinhanhDef = "Resources//Hanghoa//Default.jpg";
                        if (File.Exists(hinhanhDir))
                        {
                            A.Hinhanh = hinhanhDir;
                        }
                        else
                        {
                            A.Hinhanh = hinhanhDef;
                        }
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

        private void clearFlowPanel()
        {
            List<FlowLayoutPanel> A = new List<FlowLayoutPanel>();
            A.Add(hanghoaPnl);
            A.Add(daxoaPnl);
            foreach (FlowLayoutPanel tempPnl in A)
            {
                List<Control> listControls = tempPnl.Controls.Cast<Control>().ToList();
                foreach (Control control in listControls)
                {
                    tempPnl.Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        private void capnhatHangHoa()
        {
            clearFlowPanel();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (HangHoa hh in listHang)
            {
                PictureBox newBox = new PictureBox();
                newBox.Size = new System.Drawing.Size(100, 94);
                newBox.SizeMode = PictureBoxSizeMode.StretchImage;

                newBox.ImageLocation = hh.Hinhanh;

                // thêm điều khiển cho box
                //newBox.MouseHover += new EventHandler(picHang_Hover);
                //newBox.MouseLeave += new EventHandler(picHang_Leave);
                newBox.MouseClick += new MouseEventHandler(picHang_Click);
                newBox.Tag = hh.Mahang;
                newBox.Name = hh.Mahang;
                if (hh.TinhTrang == 0)
                    daxoaPnl.Controls.Add(newBox);
                else
                {
                    hanghoaPnl.Controls.Add(newBox);
                    source.Add(hh.Mahang);
                    source.Add(hh.Ten);
                }
            }
            //--------------------------------------- cài đặt auto search suggestion
            searchBox.AutoCompleteCustomSource = source;
        }

        private void capnhatMoTa()
        {
            pictureBox1.ImageLocation = selectedProd.Hinhanh;
            //maTxt.Text = selectedProd.Mahang;
            tenTxt.Text = selectedProd.Ten;
            giabTxt.Text = selectedProd.Giaban.ToString();
            gianTxt.Text = selectedProd.Gianhap.ToString();
            slTxt.Text = selectedProd.Soluong.ToString();
            nsxTxt.Text = selectedProd.Nhasx;
        }

        private void nhakhoForm_Load(object sender, EventArgs e)
        {
            taiCSDL();
            capnhatHangHoa();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormClosing += new FormClosingEventHandler(nhakhoForm_Close);

            // -----------------------------------cài đặt hình và tool tip
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            searchIcon.ImageLocation = "Resources\\searchicon.png";
            searchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            themhangPic.ImageLocation = "Resources\\add.png";
            xoahangPic.ImageLocation = "Resources\\minus.png";
            restoreBtn.ImageLocation = "Resources\\restore.ico";
            themhangPic.MouseHover += new EventHandler(themhangPic_Hover);
            themhangPic.MouseLeave += new EventHandler(themhangPic_Leave);
            xoahangPic.MouseHover += new EventHandler(xoahangPic_Hover);
            xoahangPic.MouseLeave += new EventHandler(xoahangPic_Leave);
            searchBox.KeyDown += new KeyEventHandler(searchBox_KeyDown);


        }



        private void hanghoaPnl_Paint(object sender, PaintEventArgs e)
        {
            hanghoaPnl.AutoScroll = true;
        }

        //----------------------- cài đặt cho hình ảnh hàng hóa
        // khi để chuột lên pic hàng
        private void picHang_Hover(object sender, EventArgs e)
        {
            // làm gì đó
        }

        // chỉnh lại về hình của mặt hàng
        private void picHang_Leave(object sender, EventArgs e)
        {
            // do nothing

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

                if (selectedProd.TinhTrang == 1)
                {
                    a = (PictureBox)hanghoaPnl.Controls[selectedProd.Mahang];
                    a.BorderStyle = BorderStyle.None;
                }
                else
                {
                    a = (PictureBox)daxoaPnl.Controls[selectedProd.Mahang];
                    a.BorderStyle = BorderStyle.None;
                }
            }

            // tạo viền cho mặt hàng đã chọn, lấy giá trị của mặt hàng vào trong selectedProd để điền vào ô mô tả
            foreach (HangHoa temp in listHang)
            {
                if (temp.Mahang == picBox.Tag.ToString())
                {
                    selectedProd = temp;
                    break;
                }
            }
            //MessageBox.Show("Clicked");
            capnhatMoTa();

        }



        //----------------------------------- cài đặt cho nút thêm hàng
        private void themhangPic_Click(object sender, EventArgs e)
        {
            Form chitiethangForm = new chitiethangForm(dbname);
            chitiethangForm.Show();
            //capnhatHangHoa();
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
            try
            {
                if (selectedProd == null)
                    throw new NullReferenceException();
                if (selectedProd.TinhTrang == 0)
                    throw new InvalidExpressionException();
                if (MessageBox.Show("Bạn muốn xóa mặt hàng " + selectedProd.Ten + " ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
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
                    update.CommandText = "UPDATE SANPHAM SET TINHTRANG=0 WHERE MASP='" + selectedProd.Mahang + "';";
                    update.Connection = ketnoi;
                    update.CommandType = CommandType.Text;
                    try
                    {
                        update.ExecuteNonQuery();
                        MessageBox.Show("Xóa hàng thành công");
                        selectedProd = null;
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
            catch (InvalidExpressionException)
            {
                MessageBox.Show("Không thể xóa mặt hàng này", "Lỗi", MessageBoxButtons.OK);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Chưa chọn mặt hàng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void xoahangPic_Hover(object sender, EventArgs e)
        {
            if (tooltipused == false)
            {
                tooltip.Show("Xóa mặt hàng", xoahangPic);
                tooltipused = true;
            }
        }
        private void xoahangPic_Leave(object sender, EventArgs e)
        {
            tooltip.Hide(xoahangPic);
            tooltipused = false;
        }


        //----------------------------------------- cài đặt nút lưu thông tin mặt hàng để thay đổi thông tin sản phẩm ngay trên giao diện

        private void svBtn_Click(object sender, EventArgs e)
        {
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


            SqlCommand update = new SqlCommand("cnsp",ketnoi);
            // câu lệnh cập nhật thông tin mặt hàng
            //update.CommandText = @"UPDATE SANPHAM SET TENSP=N'" + tenTxt.Text + @"',SOLUONG='" + slTxt.Text + @"',GIABAN='" + giabTxt.Text + @"',GIANHAP='" + gianTxt.Text + @"',NHASX=N'" +
            //    nsxTxt.Text + @"' WHERE MASP='" + selectedProd.Mahang + @"';";
            //update.Connection = ketnoi;

            //update.CommandText = "cnsp";
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.Add("@masp", SqlDbType.VarChar, 12);
            update.Parameters.Add("@tensp", SqlDbType.NVarChar, 40);
            update.Parameters.Add("@soluong", SqlDbType.Int);
            update.Parameters.Add("@giaban", SqlDbType.Float);
            update.Parameters.Add("@gianhap", SqlDbType.Float);

            update.Parameters[0].Value = selectedProd.Mahang;
            update.Parameters[1].Value = tenTxt.Text;
            update.Parameters[2].Value = slTxt.Text;
            update.Parameters[3].Value = giabTxt.Text;
            update.Parameters[4].Value = gianTxt.Text;


            try
            {
                update.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công");
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
                    capnhatMoTa();
                }
            }
        }


        //---------------------------- khôi phục hàng hóa
        private void restoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProd == null)
                    throw new NullReferenceException();
                if (selectedProd.TinhTrang != 0)
                    throw new InvalidOperationException();

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
                // câu lệnh khôi phục mặt hàng đang chọn
                update.CommandText = "UPDATE SANPHAM SET TINHTRANG=1 WHERE MASP='" + selectedProd.Mahang + "';";
                update.Connection = ketnoi;
                update.CommandType = CommandType.Text;
                try
                {
                    update.ExecuteNonQuery();
                    MessageBox.Show("Khôi phục thành công");
                    selectedProd = null;
                    taiCSDL();
                    capnhatHangHoa();

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được thông tin sản phẩm");
                }
                ketnoi.Close();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Chưa chọn mặt hàng", "Thông báo", MessageBoxButtons.OK);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Hàng hóa không cần khôi phục", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}


