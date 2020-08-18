using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        private DataProvider dp;

        public KhachHangDAO()
        {
            dp = new DataProvider();
        }

        public List<KhachHang> getAll()
        {
            return null;
        }

        public KhachHang getByID(int maKH)
        {
            return null;
        }

        public Boolean insert(KhachHang khachHang)
        {
            return true;
        }

        public Boolean delete(KhachHang khachHang)
        {
            return true;
        }

        public Boolean update(KhachHang khachHang)
        {
            return true;
        }

        
    }
}
