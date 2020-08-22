using DAO;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        private ChiTietPhieuNhapDAO chiTietPhieuNhapDAO;

        public ChiTietPhieuNhapBUS()
        {
            this.chiTietPhieuNhapDAO = new ChiTietPhieuNhapDAO();
        }

        public List<ChiTietPhieuNhap> getAll()
        {
            return this.chiTietPhieuNhapDAO.getAll();
        }

        public ChiTietPhieuNhap getByID(int MaPhieuNhap, int MaSach)
        {
            return this.chiTietPhieuNhapDAO.getByID(MaPhieuNhap, MaSach);
        }

        public List<ChiTietPhieuNhap> getByMaPhieuNhap(int MaPhieuNhap)
        {
            return this.chiTietPhieuNhapDAO.getByMaPhieuNhap(MaPhieuNhap);
        }

        public Boolean insert(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            return this.chiTietPhieuNhapDAO.insert(chiTietPhieuNhap);
        }

        public Boolean delete(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            return this.chiTietPhieuNhapDAO.delete(chiTietPhieuNhap);
        }

        public Boolean update(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            return this.chiTietPhieuNhapDAO.update(chiTietPhieuNhap);
        }
    }
}
