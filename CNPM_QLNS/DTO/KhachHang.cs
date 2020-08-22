using System;

namespace DTO
{
    public class KhachHang
    {
        public int MaKhachHang { get; set; }
        public String HoTen { get; set; }
        public String DiaChi { get; set; }
        public String DienThoai { get; set; }
        public Decimal SoTienNoDau { get; set; }
        public Decimal SoTienNoCuoi { get; set; }

        public KhachHang()
        {
        }

        public KhachHang(string hoTen, string diaChi, string dienThoai, decimal soTienNoDau, decimal soTienNoCuoi)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            SoTienNoDau = soTienNoDau;
            SoTienNoCuoi = soTienNoCuoi;
        }

    }
}
