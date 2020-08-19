using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int MaPhieuThu { get; set; }
        public int MaKhachHang { get; set; }

        public HoaDon()
        {
        }

        public HoaDon(DateTime ngayLapHD, int maPhieuThu, int maKhachHang)
        {
            NgayLapHD = ngayLapHD;
            MaPhieuThu = maPhieuThu;
            MaKhachHang = maKhachHang;
        }
    }
}
