using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /*public ChiTietPhieuNhap getByID(int MaPhieuNhap, int MaSach)
        {
            return this.chiTietPhieuNhapDAO.getByID(MaPhieuNhap, MaSach);
        }*/

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
