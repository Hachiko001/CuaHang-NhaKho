using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CửaHàng_NhàKho
{
    public class HangHoa
    {
        public HangHoa(HangHoa hanghoa)
        {
            ten = hanghoa.Ten;
            mota = hanghoa.Mota;
            soluong = hanghoa.Soluong;
            nhasx = hanghoa.Nhasx;
            giaban = hanghoa.Giaban;
            gianhap = hanghoa.Gianhap;
            mahang = hanghoa.Mahang;
            hinhanh = hanghoa.Hinhanh;
            tinhTrang = hanghoa.TinhTrang;
        }
        public HangHoa()
        {

        }
        private string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private string mota;
        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        private float gianhap;
        public float Gianhap
        {
            get { return gianhap; }
            set { gianhap = value; }
        }

        private float giaban;
        public float Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }
        private string mahang;
        public string Mahang
        {
            get { return mahang; }
            set { mahang = value; }
        }
        private string nhasx;
        public string Nhasx
        {
            get { return nhasx; }
            set { nhasx = value; }
        }
        private int soluong;
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private string hinhanh;
        public string Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }
        private int tinhTrang;
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }


    }
}
