using DAO;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class QuyDinhBUS
    {
        private QuyDinhDAO quyDinhDAO;

        public QuyDinhBUS()
        {
            this.quyDinhDAO = new QuyDinhDAO();
        }

        public List<QuyDinh> getAll()
        {
            return this.quyDinhDAO.getAll();
        }

        public QuyDinh getByID(int maQuyDinh)
        {
            return this.quyDinhDAO.getByID(maQuyDinh);
        }

        public Boolean insert(QuyDinh quyDinh)
        {
            return this.quyDinhDAO.insert(quyDinh);
        }

        public Boolean delete(QuyDinh quyDinh)
        {
            return this.quyDinhDAO.delete(quyDinh);
        }

        public Boolean update(QuyDinh quyDinh)
        {
            return this.quyDinhDAO.update(quyDinh);
        }
    }
}
