using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO khachHangDAO;

        public KhachHangBUS()
        {
            this.khachHangDAO = new KhachHangDAO();
        }

        public List<KhachHang> getAllReturnList()
        {
            return this.khachHangDAO.getAllReturnList();
        }

        public DataTable getAllReturnDataTable()
        {
            return this.khachHangDAO.getAllReturnDataTable();
        }

        public KhachHang getByID(int maKhachHang)
        {
            return this.khachHangDAO.getByID(maKhachHang);
        }

        public KhachHang getBySDT(String DienThoai)
        {
            return this.khachHangDAO.getBySDT(DienThoai);
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
