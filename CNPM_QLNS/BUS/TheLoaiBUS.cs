using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class TheLoaiBUS
    {
        private TheLoaiDAO theLoaiDAO;

        public TheLoaiBUS()
        {
            this.theLoaiDAO = new TheLoaiDAO();
        }

        public List<TheLoai> getAllReturnList()
        {
            return this.theLoaiDAO.getAllReturnList();
        }

        public DataTable getAllReturnDataTable()
        {
            return this.theLoaiDAO.getAllReturnDataTable();
        }

        public TheLoai getByID(int maTheLoai)
        {
            return this.theLoaiDAO.getByID(maTheLoai);
        }

        public TheLoai getByTenTheLoai(String TenTheLoai)
        {
            return this.theLoaiDAO.getByTenTheLoai(TenTheLoai);
        }

        public Boolean insert(TheLoai theLoai)
        {
            return this.theLoaiDAO.insert(theLoai);
        }

        public Boolean delete(TheLoai theLoai)
        {
            return this.theLoaiDAO.delete(theLoai);
        }

        public Boolean update(TheLoai theLoai)
        {
            return this.theLoaiDAO.update(theLoai);
        }
    }
}
