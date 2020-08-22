using System;

namespace DTO
{
    public class Sach
    {
        public int MaSach { get; set; }
        public String TenSach { get; set; }
        public int MaTheLoai { get; set; }
        public String TacGia { get; set; }
        public int SoLuongTonDau { get; set; }
        public int SoLuongTonCuoi { get; set; }
        public Decimal DonGia { get; set; }

        public Sach()
        {
        }

        public Sach(string tenSach, int maTheLoai, string tacGia, int soLuongTonDau, int soLuongTonCuoi, decimal donGia)
        {
            TenSach = tenSach;
            MaTheLoai = maTheLoai;
            TacGia = tacGia;
            SoLuongTonDau = soLuongTonDau;
            SoLuongTonCuoi = soLuongTonCuoi;
            DonGia = donGia;
        }
    }
}
