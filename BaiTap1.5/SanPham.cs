using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1._5
{
    internal class SanPham
    {
        
        public int MaSanPham { get; set; }

        public string TenSp { get; set; }

        public int DonGia { get; set; }

        public int SoLuong { get; set; }


        public SanPham()
        {
                
        }

        public SanPham(int  maSanPham, string tenSp, int donGia, int soLuong)
        {
            MaSanPham = maSanPham;
            TenSp = tenSp;
            DonGia = donGia;
            SoLuong = soLuong;
        }

    }
}
