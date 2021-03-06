﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAO hoaDonDAO;

        public HoaDonBUS()
        {
            this.hoaDonDAO = new HoaDonDAO();
        }

        public List<HoaDon> getAllReturnList()
        {
            return this.hoaDonDAO.getALlReturnList();
        }

        public DataTable getALlReturnDataTable()
        {
            return this.hoaDonDAO.getALlReturnDataTable();
        }

        public HoaDon getByID(int maHoaDon)
        {
            return this.hoaDonDAO.getByID(maHoaDon);
        }

        public Boolean insert(HoaDon hoaDon)
        {
            return this.hoaDonDAO.insert(hoaDon);
        }

        public Boolean delete(HoaDon hoaDon)
        {
            return this.hoaDonDAO.delete(hoaDon);
        }

        public Boolean update(HoaDon hoaDon)
        {
            return this.hoaDonDAO.update(hoaDon);
        }
    }
}
