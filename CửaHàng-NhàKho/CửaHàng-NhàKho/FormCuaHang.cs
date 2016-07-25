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
    public partial class cuahangForm : Form
    {
        public cuahangForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += new FormClosingEventHandler(CuaHang_Close);
        }

        private void CuaHang_Close(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //khong lam gi ca
            }
        }

        private void cuahangForm_Load(object sender, EventArgs e)
        {
            themdsPic.ImageLocation = "Resources\\signin.png";
            xoadsPic.ImageLocation = "Resources\\signout.png";
        }
    }
}
