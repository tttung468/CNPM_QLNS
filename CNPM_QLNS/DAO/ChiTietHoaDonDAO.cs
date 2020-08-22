
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
    public class ChiTietHoaDonDAO
    {
        private DataProvider dp;

        public ChiTietHoaDonDAO()
        {
            dp = new DataProvider();
        }

        public List<ChiTietHoaDon> getAll()
        {
            String query = "select MaHoaDon,MaSach,SoLuongMua from ChiTietHoaDon";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<ChiTietHoaDon> lstChiTietHoaDon = new List<ChiTietHoaDon>();
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.MaHoaDon = (int)dr["MaHoaDon"];
                chiTietHoaDon.MaSach = (int)dr["MaSach"];
                chiTietHoaDon.SoLuongMua = (int)dr["SoLuongMua"];

                lstChiTietHoaDon.Add(chiTietHoaDon);
            }
            return lstChiTietHoaDon;
        }
        public ChiTietHoaDon getByID(int MaHoaDon, int MaSach)
        {

            String query = "select MaHoaDon,MaSach,SoLuongMua from ChiTietHoaDon where MaHoaDon = @MaHoaDon and MaSach=@MaSach";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param_MaHoaDon = new SqlParameter("MaHoaDon", MaHoaDon);
            sqlParameters.Add(param_MaHoaDon);
            SqlParameter param_MaSach = new SqlParameter("MaSach", MaSach);
            sqlParameters.Add(param_MaSach);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.MaHoaDon = (int)dt.Rows[0]["MaHoaDon"];
                chiTietHoaDon.MaSach = (int)dt.Rows[0]["SoLuongMua"];
                chiTietHoaDon.SoLuongMua = (int)dt.Rows[0]["SoLuongMua"];


                return chiTietHoaDon;
            }
        }

        public List<ChiTietHoaDon> getByMaHoaDon(int MaHoaDon)
        {

            String query = "select MaHoaDon,MaSach,SoLuongMua from ChiTietHoaDon where MaHoaDon = @MaHoaDon";

            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaHoaDon", MaHoaDon);
            sqlParameters.Add(param);

            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            List<ChiTietHoaDon> lstChiTietHoaDon = new List<ChiTietHoaDon>();
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.MaHoaDon = (int)dr["MaHoaDon"];
                chiTietHoaDon.MaSach = (int)dr["MaSach"];
                chiTietHoaDon.SoLuongMua = (int)dr["SoLuongMua"];

                lstChiTietHoaDon.Add(chiTietHoaDon);
            }
            return lstChiTietHoaDon;
        }

        public Boolean insert(ChiTietHoaDon chiTietHoaDon)
        {

            String query = "insert into ChiTietHoaDon(MaHoaDon,MaSach,SoLuongMua) values(@MaHoaDon, @MaSach, @SoLuongMua))";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_MaHoaDon = new SqlParameter("MaHoaDon", chiTietHoaDon.MaHoaDon);
            SqlParameter param_MaSach = new SqlParameter("MaSach", chiTietHoaDon.MaSach);
            SqlParameter param_SoLuongMua = new SqlParameter("SoLuongMua", chiTietHoaDon.SoLuongMua);

            sqlParameters.Add(param_MaHoaDon);
            sqlParameters.Add(param_MaSach);
            sqlParameters.Add(param_SoLuongMua);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(ChiTietHoaDon chiTietHoaDon)
        {

            String query = "delete from ChiTietHoaDon where MaHoaDon = @MaHoaDon";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaHoaDon", chiTietHoaDon.MaHoaDon);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(ChiTietHoaDon chiTietHoaDon)
        {

            String query = "update ChiTietHoaDon set MaSach = @MaSach, SoLuongMua = @SoLuongMua where MaHoaDon = @MaHoaDon";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_MaHoaDon = new SqlParameter("MaHoaDon", chiTietHoaDon.MaHoaDon);
            SqlParameter param_MaSach = new SqlParameter("MaSach", chiTietHoaDon.MaSach);
            SqlParameter param_SoLuongMua = new SqlParameter("SoLuongMua", chiTietHoaDon.SoLuongMua);

            sqlParameters.Add(param_MaHoaDon);
            sqlParameters.Add(param_MaSach);
            sqlParameters.Add(param_SoLuongMua);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }


    }
}
