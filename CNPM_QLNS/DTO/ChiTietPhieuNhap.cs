using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public int MaSach { get; set; }
        public int SoLuongNhap { get; set; }

        public ChiTietPhieuNhap()
        {
        }

        public ChiTietPhieuNhap(int maSach, int soLuongNhap)
        {
            MaSach = maSach;
            SoLuongNhap = soLuongNhap;
        }
    }
}
