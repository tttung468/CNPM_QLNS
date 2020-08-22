using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class SachBUS
    {
        private SachDAO sachDAO;

        public SachBUS()
        {
            this.sachDAO = new SachDAO();
        }

        public List<Sach> getAllReturnList()
        {
            return this.sachDAO.getAll();
        }

        public DataTable getAllReturnDataTable()
        {
            return this.sachDAO.getAllForDgvSach();
        }

        public Sach getByID(int maQuyDinh)
        {
            return this.sachDAO.getByID(maQuyDinh);
        }

        public Sach getByThuocTinh(String TenSach, int MaTheLoai, String TacGia)
        {
            return sachDAO.getByThuocTinh(TenSach, MaTheLoai, TacGia);
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
