using System;

namespace DTO
{
    public class PhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }

        public PhieuNhap()
        {
        }

        public PhieuNhap(DateTime ngayNhap)
        {
            NgayNhap = ngayNhap;
        }
    }
}
