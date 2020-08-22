using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SachBUS
    {
        private SachDAO sachDAO;

        public SachBUS()
        {
            this.sachDAO = new SachDAO();
        }

        public List<Sach> getAll()
        {
            return this.sachDAO.getAll();
        }

        public DataTable getAllForDgvSach()
        {
            return this.sachDAO.getAllForDgvSach();
        }

        public Sach getByID(int maQuyDinh)
        {
            return this.sachDAO.getByID(maQuyDinh);
        }

        public Boolean insert(Sach sach)
        {
            return this.sachDAO.insert(sach);
        }

        public Boolean delete(Sach sach)
        {
            return this.sachDAO.delete(sach);
        }

        public Boolean update(Sach sach)
        {
            return this.sachDAO.update(sach);
        }
    }
}
