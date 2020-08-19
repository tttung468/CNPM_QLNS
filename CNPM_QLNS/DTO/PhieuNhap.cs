using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
