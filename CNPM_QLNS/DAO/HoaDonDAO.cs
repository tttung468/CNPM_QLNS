using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        private DataProvider dp;

        public HoaDonDAO()
        {
            dp = new DataProvider();
        }

        public List<HoaDon> getAll()
        {
            String query = "select MaHoaDon,NgayLapHD,MaPhieuThu,MaKhachHang from HoaDon";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<HoaDon> lstHoaDon = new List<HoaDon>();
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = (int)dr["MaHoaDon"];
                hoaDon.NgayLapHD = (DateTime)dr["NgayLapHD"];
                hoaDon.MaPhieuThu = (int)dr["MaPhieuThu"];
                hoaDon.MaKhachHang = (int)dr["MaKhachHang"];

                lstHoaDon.Add(hoaDon);
            }
            return lstHoaDon;
        }

        public HoaDon getByID(int MaHoaDon)
        {

            String query = "select MaHoaDon,NgayLapHD,MaPhieuThu,MaKhachHang from HoaDon where MaHoaDon = @MaHoaDon";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaHoaDon", MaHoaDon);
            sqlParameters.Add(param);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = (int)dt.Rows[0]["MaHoaDon"];
                hoaDon.NgayLapHD = (DateTime)dt.Rows[0]["NgayLapHD"];
                hoaDon.MaPhieuThu = (int)dt.Rows[0]["MaPhieuThu"];
                hoaDon.MaKhachHang = (int)dt.Rows[0]["MaKhachHang"];


                return hoaDon;
            }
        }

        public Boolean insert(HoaDon hoaDon)
        {

            String query = "insert into HoaDon(NgayLapHD,MaPhieuThu,MaKhachHang) values(@NgayLapHD, @MaPhieuThu, @MaKhachHang)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_NgayLapHD = new SqlParameter("NgayLapHD", hoaDon.NgayLapHD);
            SqlParameter param_MaPhieuThu = new SqlParameter("MaPhieuThu", hoaDon.MaPhieuThu);
            SqlParameter param_MaKhachHang = new SqlParameter("MaKhachHang", hoaDon.MaKhachHang);

            sqlParameters.Add(param_NgayLapHD);
            sqlParameters.Add(param_MaPhieuThu);
            sqlParameters.Add(param_MaKhachHang);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(HoaDon hoaDon)
        {

            String query = "delete from HoaDon where MaHoaDon = @MaHoaDon";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaHoaDon", hoaDon.MaHoaDon);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(HoaDon hoaDon)
        {

            String query = "update HoaDon set NgayLapHD = @NgayLapHD, MaPhieuThu = @MaPhieuThu, MaKhachHang = @MaKhachHang where MaHoaDon = @MaHoaDon";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_NgayLapHD = new SqlParameter("NgayLapHD", hoaDon.NgayLapHD);
            SqlParameter param_MaPhieuThu = new SqlParameter("MaPhieuThu", hoaDon.MaPhieuThu);
            SqlParameter param_MaKhachHang = new SqlParameter("MaKhachHang", hoaDon.MaKhachHang);
            SqlParameter param_MaHoaDon = new SqlParameter("MaKhachHang", hoaDon.MaKhachHang);

            sqlParameters.Add(param_NgayLapHD);
            sqlParameters.Add(param_MaPhieuThu);
            sqlParameters.Add(param_MaKhachHang);
            sqlParameters.Add(param_MaHoaDon);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        
    }
}
