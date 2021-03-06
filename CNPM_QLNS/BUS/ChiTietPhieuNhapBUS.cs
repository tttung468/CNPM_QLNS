﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        private ChiTietPhieuNhapDAO chiTietPhieuNhapDAO;

        public ChiTietPhieuNhapBUS()
        {
            this.chiTietPhieuNhapDAO = new ChiTietPhieuNhapDAO();
        }

        public List<ChiTietPhieuNhap> getAllReturnList()
        {
            return this.chiTietPhieuNhapDAO.getAllReturnList();
        }

        public DataTable getAllReturnDataTable()
        {
            return this.chiTietPhieuNhapDAO.getAllReturnDataTable();
        }

        public ChiTietPhieuNhap getByID(int MaPhieuNhap, int MaSach)
        {
            return this.chiTietPhieuNhapDAO.getByID(MaPhieuNhap, MaSach);
        }

        public List<ChiTietPhieuNhap> getByMaPhieuNhap(int MaPhieuNhap)
        {
            return this.chiTietPhieuNhapDAO.getByMaPhieuNhap(MaPhieuNhap);
        }

        public DataTable getByMaPhieuNhapReturnDataTable(int MaPhieuNhap)
        {
            return this.chiTietPhieuNhapDAO.getByMaPhieuNhapReturnDataTable(MaPhieuNhap);
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
