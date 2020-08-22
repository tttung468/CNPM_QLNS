using System;

namespace DTO
{
    public class TheLoai
    {
        public int MaTheLoai { get; set; }
        public String TenTheLoai { get; set; }

        public TheLoai()
        {
        }

        public TheLoai(string tenTheLoai)
        {
            TenTheLoai = tenTheLoai;
        }
    }
}
