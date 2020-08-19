using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
