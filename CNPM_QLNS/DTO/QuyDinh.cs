using System;

namespace DTO
{
    public class QuyDinh
    {
        public int MaQuyDinh { get; set; }
        public String TenQuyDinh { get; set; }
        public int GiaTri { get; set; }

        public QuyDinh()
        {
        }

        public QuyDinh(string tenQuyDinh, int giaTri)
        {
            TenQuyDinh = tenQuyDinh;
            GiaTri = giaTri;
        }
    }
}
