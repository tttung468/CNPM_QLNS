using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuThuBUS
    {
        private PhieuThuDAO phieuThuDAO;

        public PhieuThuBUS()
        {
            this.phieuThuDAO = new PhieuThuDAO();
        }

        public List<PhieuThu> getAll()
        {
            return this.phieuThuDAO.getAll();
        }

        public PhieuThu getByID(int maPhieuThu)
        {
            return this.phieuThuDAO.getByID(maPhieuThu);
        }

        public Boolean insert(PhieuThu phieuThu)
        {
            return this.phieuThuDAO.insert(phieuThu);
        }

        public Boolean delete(PhieuThu phieuThu)
        {
            return this.phieuThuDAO.delete(phieuThu);
        }

        public Boolean update(PhieuThu phieuThu)
        {
            return this.phieuThuDAO.update(phieuThu);
        }
    }
}
