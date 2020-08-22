using DAO;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        private ChiTietHoaDonDAO chiTietHoaDonDAO;

        public ChiTietHoaDonBUS()
        {
            this.chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        }

        public List<ChiTietHoaDon> getAll()
        {
            return this.chiTietHoaDonDAO.getAll();
        }

        public ChiTietHoaDon getByID(int MaHoaDon, int MaSach)
        {
            return this.chiTietHoaDonDAO.getByID(MaHoaDon, MaSach);
        }

        public List<ChiTietHoaDon> getByMaHoaDon(int MaHoaDon)
        {
            return this.chiTietHoaDonDAO.getByMaHoaDon(MaHoaDon);
        }

        public Boolean insert(ChiTietHoaDon chiTietHoaDon)
        {
            return this.chiTietHoaDonDAO.insert(chiTietHoaDon);
        }

        public Boolean delete(ChiTietHoaDon chiTietHoaDon)
        {
            return this.chiTietHoaDonDAO.delete(chiTietHoaDon);
        }

        public Boolean update(ChiTietHoaDon chiTietHoaDon)
        {
            return this.chiTietHoaDonDAO.update(chiTietHoaDon);
        }
    }
}
