using System;

namespace DTO
{
    public class PhieuThu
    {
        public int MaPhieuThu { get; set; }
        public DateTime NgayThuTien { get; set; }
        public Decimal SoTienThu { get; set; }

        public PhieuThu()
        {
        }

        public PhieuThu(DateTime ngayThuTien, decimal soTienThu)
        {
            NgayThuTien = ngayThuTien;
            SoTienThu = soTienThu;
        }
    }
}
