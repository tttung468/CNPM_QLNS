using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class PhieuNhapBUS
    {
        private PhieuNhapDAO phieuNhapDAO;

        public PhieuNhapBUS()
        {
            this.phieuNhapDAO = new PhieuNhapDAO();
        }

        public List<PhieuNhap> getAllReturnList()
        {
            return this.phieuNhapDAO.getAllReturnList();
        }

        public DataTable getAllReturnDataTable()
        {
            return this.phieuNhapDAO.getAllReturnDataTable();
        }

        public PhieuNhap getByID(int maPhieuNhap)
        {
            return this.phieuNhapDAO.getByID(maPhieuNhap);
        }

        public Boolean insert(PhieuNhap phieuNhap)
        {
            return this.phieuNhapDAO.insert(phieuNhap);
        }

        public Boolean delete(PhieuNhap phieuNhap)
        {
            return this.phieuNhapDAO.delete(phieuNhap);
        }

        public Boolean update(PhieuNhap phieuNhap)
        {
            return this.phieuNhapDAO.update(phieuNhap);
        }
    }
}
