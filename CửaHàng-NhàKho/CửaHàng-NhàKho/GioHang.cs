using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CửaHàng_NhàKho
{
    class GioHang
    {
        public List<HangHoa> dsHang = new List<HangHoa>();
        public float tongtien = 0;

        public bool themHang(HangHoa A, int soluong)
        {
            HangHoa temp = new HangHoa(A);
            temp.Soluong = soluong;
            if (dsHang.Count==0)
            {
                dsHang.Add(temp);
                tongtien = temp.Soluong * temp.Giaban;
                return true;
            }
            else
            {
                for (int i=0; i<dsHang.Count;i++)
                {
                    if(dsHang[i].Mahang== A.Mahang)
                    {
                        int tempSL = dsHang[i].Soluong + soluong;
                        if (tempSL > A.Soluong)
                        {
                            return false;
                        }
                        else
                        {
                            dsHang[i].Soluong += soluong;
                            tongtien += temp.Soluong * temp.Giaban;
                            return true;
                        }
                    }
                }
                dsHang.Add(temp);
                tongtien += temp.Soluong * temp.Giaban;
                return true;
            }
        }

        public bool xoaHang(string mahang)
        {
            for (int i = 0; i < dsHang.Count; i++)
            {
                if(dsHang[i].Mahang==mahang)
                {
                    dsHang.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void xoaGioHang()
        {
            dsHang.Clear();
        }
    }
}
