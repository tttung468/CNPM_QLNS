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
    public class ChiTietPhieuNhapDAO
    {
        private DataProvider dp;

        public ChiTietPhieuNhapDAO()
        {
            dp = new DataProvider();
        }

        public List<ChiTietPhieuNhap> getAll()
        {
            String query = "select MaPhieuNhap,MaSach,SoLuongNhap from ChiTietPhieuNhap";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<ChiTietPhieuNhap> lstChiTietPhieuNhap = new List<ChiTietPhieuNhap>();
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                chiTietPhieuNhap.MaPhieuNhap = (int)dr["MaPhieuNhap"];
                chiTietPhieuNhap.MaSach = (int)dr["MaSach"];

                chiTietPhieuNhap.SoLuongNhap = (int)dr["SoLuongNhap"];

                lstChiTietPhieuNhap.Add(chiTietPhieuNhap);
            }
            return lstChiTietPhieuNhap;
        }

        public List<ChiTietPhieuNhap> getByID(int MaPhieuNhap, int MaSach)
        {

            String query = "select MaPhieuNhap,MaSach,SoLuongNhap from ChiTietPhieuNhap where MaPhieuNhap=@MaPhieuNhap and MaSach=@MaSach";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_MaPhieuNhap = new SqlParameter("MaPhieuNhap", MaPhieuNhap);
          
            SqlParameter param_MaSach = new SqlParameter("MaSach", MaSach);
            sqlParameters.Add(param_MaPhieuNhap);
            sqlParameters.Add(param_MaSach);

            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            List<ChiTietPhieuNhap> lstChiTietPhieuNhap = new List<ChiTietPhieuNhap>();
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                chiTietPhieuNhap.MaPhieuNhap = (int)dr["MaPhieuNhap"];
                chiTietPhieuNhap.MaSach = (int)dr["MaSach"];

                chiTietPhieuNhap.SoLuongNhap = (int)dr["SoLuongNhap"];

                lstChiTietPhieuNhap.Add(chiTietPhieuNhap);
            }
            return lstChiTietPhieuNhap;
        }
        public ChiTietPhieuNhap getByMaPhieuNhap(int MaPhieuNhap)
        {

            String query = "select MaPhieuNhap,MaSach,SoLuongNhap from ChiTietPhieuNhap where MaPhieuNhap=@MaPhieuNhap";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaPhieuNhap", MaPhieuNhap);
            sqlParameters.Add(param);
            
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                chiTietPhieuNhap.MaPhieuNhap = (int)dt.Rows[0]["MaPhieuNhap"];
                chiTietPhieuNhap.MaSach = (int)dt.Rows[0]["MaSach"];
                chiTietPhieuNhap.SoLuongNhap = (int)dt.Rows[0]["SoLuongNhap"];


                return chiTietPhieuNhap;
            }
        }

        public Boolean insert(ChiTietPhieuNhap chiTietPhieuNhap)
        {

            String query = "insert ChiTietPhieuNhap(MaPhieuNhap,MaSach,SoLuongNhap) values(@MaPhieuNhap, @MaSach, @SoLuongNhap)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_MaPhieuNhap = new SqlParameter("MaPhieuNhap", chiTietPhieuNhap.MaPhieuNhap);
            SqlParameter param_MaSach = new SqlParameter("MaSach", chiTietPhieuNhap.MaPhieuNhap);
            SqlParameter param_SoLuongNhap = new SqlParameter("SoLuongNhap", chiTietPhieuNhap.SoLuongNhap);

            sqlParameters.Add(param_MaPhieuNhap);
            sqlParameters.Add(param_MaSach);
            sqlParameters.Add(param_SoLuongNhap);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(ChiTietPhieuNhap chiTietPhieuNhap)
        {

            String query = "delete from ChiTietPhieuNhap where MaPhieuNhap = @MaPhieuNhap";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaPhieuNhap", chiTietPhieuNhap.MaPhieuNhap);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(ChiTietPhieuNhap chiTietPhieuNhap)
        {

            String query = "update ChiTietPhieuNhap set MaSach = @MaSach, SoLuongNhap = @SoLuongNhap where MaPhieuNhap = @MaPhieuNhap";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_MaSach = new SqlParameter("MaSach", chiTietPhieuNhap.MaSach);
            SqlParameter param_SoLuongNhap = new SqlParameter("SoLuongNhap", chiTietPhieuNhap.SoLuongNhap);
            SqlParameter param_MaPhieuNhap = new SqlParameter("MaPhieuNhap", chiTietPhieuNhap.MaPhieuNhap);

            sqlParameters.Add(param_MaSach);
            sqlParameters.Add(param_SoLuongNhap);
            sqlParameters.Add(param_MaPhieuNhap);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }


    }
}
