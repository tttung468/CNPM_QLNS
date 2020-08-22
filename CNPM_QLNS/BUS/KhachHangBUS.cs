using DAO;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO khachHangDAO;

        public KhachHangBUS()
        {
            this.khachHangDAO = new KhachHangDAO();
        }

        public List<KhachHang> getAll()
        {
            return this.khachHangDAO.getAll();
        }

        public KhachHang getByID(int maKhachHang)
        {
            return this.khachHangDAO.getByID(maKhachHang);
        }

        public Boolean insert(KhachHang khachHang)
        {
            return this.khachHangDAO.insert(khachHang);
        }

        public Boolean delete(KhachHang khachHang)
        {
            return this.khachHangDAO.delete(khachHang);
        }

        public Boolean update(KhachHang khachHang)
        {
            return this.khachHangDAO.update(khachHang);
        }
    }
}
