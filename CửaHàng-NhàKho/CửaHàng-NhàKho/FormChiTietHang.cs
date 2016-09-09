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
    public partial class chitiethangForm : Form
    {
        HangHoa hanghoa = new HangHoa();
        private bool nonNumberEntered = false;
        private bool tooltipused = false;
        private ToolTip tooltip = new ToolTip();
        //nhakhoFrom NKForm = new nhakhoFrom();
        string connectStr = null;
        

        
        public chitiethangForm(string dbname)
        {
            InitializeComponent();
            //NKForm = form1;
            connectStr = "Integrated Security=SSPI;Server="+dbname+";Database=QUAN_LY_CUA_HANG";

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormChiTietHang_Load(object sender, EventArgs e)
        {
            // cài đặt hình ảnh cho form
            themhinhPic.ImageLocation = "Resources\\addfile.png";
            themhinhPic.Visible = true;
            anhhangPic.SizeMode = PictureBoxSizeMode.StretchImage;
            // cài đặt phần chỉ cho phep số vào những text box này
            soluongBox.KeyDown += textBox1_KeyDown;
            soluongBox.KeyPress += textBox1_KeyPress;
            giabanBox.KeyDown += textBox1_KeyDown;
            giabanBox.KeyPress += textBox1_KeyPress;
            gianhapBox.KeyDown += textBox1_KeyDown;
            gianhapBox.KeyPress += textBox1_KeyPress;
            // cài đặt tooltip cho các nút bấm hình
            themhinhPic.MouseHover += new EventHandler(themhinhPic_Hover);
            themhinhPic.MouseLeave += new EventHandler(themhinhPic_Leave);

            // cài đặt giá trị cho numericbox
            soluongBox.Minimum = 0;
            soluongBox.Value = Decimal.Round(soluongBox.Value, 0);          // làm tròn giá trị nhập
        }

        private void tenBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void themhinhPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog picBrw = new OpenFileDialog();
            picBrw.InitialDirectory = "C:\\";
            picBrw.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";
            picBrw.Title = "Chọn hình ảnh";
            if(picBrw.ShowDialog()==DialogResult.OK)
            {
                if (picBrw.CheckFileExists)
                {
                    MessageBox.Show(null, picBrw.FileName, "Selected file path", MessageBoxButtons.OK);
                    anhhangPic.ImageLocation = picBrw.FileName;
                }
                else
                {
                    MessageBox.Show(null, picBrw.FileName, "Invalid directory", MessageBoxButtons.OK);
                }

            }
        }
        private void themhinhPic_Hover(object sender, EventArgs e)
        {
            if (tooltipused == false)
            {
                tooltip.Show("Chọn/Thay đổi hình ảnh", themhinhPic);
                tooltipused = true;
            }
        }
        private void themhinhPic_Leave(object sender, EventArgs e)
        {
            tooltip.Hide(themhinhPic);
            tooltipused = false;
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            hanghoa.Ten = tenBox.Text;
            hanghoa.Giaban = Convert.ToSingle(giabanBox.Text);
            hanghoa.Gianhap = Convert.ToSingle(gianhapBox.Text);
            hanghoa.Mahang = maBox.Text;
            hanghoa.Nhasx = nhasxBox.Text;
            hanghoa.Soluong = Convert.ToInt32(soluongBox.Value);
            hanghoa.Hinhanh = anhhangPic.ImageLocation;
            hanghoa.TinhTrang = 1;


            //lưu vào sql server
            
            // Tạo kết nối đến sql server
            SqlConnection ketnoi = new SqlConnection(connectStr);
            try
            {
                ketnoi.Open();
            }
            catch(System.Configuration.ConfigurationException)
            {
                MessageBox.Show("Không thể kết nối vào cơ sở dữ liệu", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // gắn kết nối cho lenhSQL
            SqlCommand lenhSQL = new SqlCommand();
            lenhSQL.Connection = ketnoi;
            //lenhSQL.CommandText = "INSERT SANPHAM VALUES('"+hanghoa.Mahang+"', N'"+hanghoa.Ten+"', "+hanghoa.Soluong+", "+hanghoa.Giaban+","+hanghoa.Gianhap+", N'"+hanghoa.Nhasx+"')";
            lenhSQL.CommandText = "dbo.themSP";
            lenhSQL.CommandType = CommandType.StoredProcedure;

            lenhSQL.Parameters.Add("@masp", SqlDbType.VarChar, 12);
            lenhSQL.Parameters.Add("@tensp", SqlDbType.NVarChar, 40);
            lenhSQL.Parameters.Add("@soluong", SqlDbType.Int);
            lenhSQL.Parameters.Add("@giaban", SqlDbType.Float);
            lenhSQL.Parameters.Add("@gianhap", SqlDbType.Float);
            lenhSQL.Parameters.Add("@nhasx", SqlDbType.NVarChar,40);
            lenhSQL.Parameters.Add("@tinhtrang", SqlDbType.Int);

            lenhSQL.Parameters[0].Value = hanghoa.Mahang;
            lenhSQL.Parameters[1].Value = hanghoa.Ten;
            lenhSQL.Parameters[2].Value = hanghoa.Soluong;
            lenhSQL.Parameters[3].Value = hanghoa.Giaban;
            lenhSQL.Parameters[4].Value = hanghoa.Gianhap;
            lenhSQL.Parameters[5].Value = hanghoa.Nhasx;
            lenhSQL.Parameters[6].Value = hanghoa.TinhTrang;

            try
            {
                lenhSQL.ExecuteNonQuery();

                // copy hình vào thư mục hàng hóa

                if (anhhangPic.ImageLocation != null)
                {
                    string filename = hanghoa.Mahang + ".jpg";
                    string src = anhhangPic.ImageLocation;
                    string dest = System.IO.Path.Combine(@"Resources\Hanghoa", filename);

                    System.IO.File.Copy(src, dest, true);

                }

                DialogResult result= MessageBox.Show("Thêm hàng thành công, nhấn ok để thoát cửa số này", "Thông báo", MessageBoxButtons.OKCancel);
                if(result== DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    // do nothing
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Thêm vào thất bại, hãy nhập lại thông tin.", "Thông báo lỗi");
            }
               

        }


        //Source: https://msdn.microsoft.com/en-us/library/system.windows.forms.control.keypress.aspx
        //Handler for nonNumberPressed 
        //Used for soluongBox,gianhapBox, giabanBox


        // Handle the KeyDown event to determine the type of character entered into the control.
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            //if (DialogResult.OK == MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel)) 
                this.Close();
        }
    }
}
