using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoaiBUS
    {
        private TheLoaiDAO theLoaiDAO;

        public TheLoaiBUS()
        {
            this.theLoaiDAO = new TheLoaiDAO();
        }

        public List<TheLoai> getAll()
        {
            return this.theLoaiDAO.getAll();
        }

        public TheLoai getByID(int maTheLoai)
        {
            return this.theLoaiDAO.getByID(maTheLoai);
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
