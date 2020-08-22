namespace DTO
{
    public class ChiTietHoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaSach { get; set; }
        public int SoLuongMua { get; set; }

        public ChiTietHoaDon()
        {
        }

        public ChiTietHoaDon(int maSach, int soLuongMua)
        {
            MaSach = maSach;
            SoLuongMua = soLuongMua;
        }
    }
}
