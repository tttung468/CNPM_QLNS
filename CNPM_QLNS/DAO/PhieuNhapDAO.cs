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
    public class PhieuNhapDAO
    {
        private DataProvider dp;

        public PhieuNhapDAO()
        {
            dp = new DataProvider();
        }

        public List<PhieuNhap> getAll()
        {
            String query = "select MaPhieuNhap,NgayNhap from PhieuNhap";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<PhieuNhap> lstPhieuNhap = new List<PhieuNhap>();
            foreach (DataRow dr in dt.Rows)
            {
                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.MaPhieuNhap = (int)dr["MaPhieuNhap"];
                phieuNhap.NgayNhap = (DateTime)dr["NgayNhap"];


                lstPhieuNhap.Add(phieuNhap);
            }
            return lstPhieuNhap;
        }

        public PhieuNhap getByID(int MaPhieuNhap)
        {

            String query = "select NgayNhap from PhieuNhap where MaPhieuNhap=@MaPhieuNhap";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaPhieuNhap", MaPhieuNhap);
            sqlParameters.Add(param);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                PhieuNhap phieuNhap = new PhieuNhap();
                phieuNhap.MaPhieuNhap = (int)dt.Rows[0]["MaPhieuNhap"];
                phieuNhap.NgayNhap = (DateTime)dt.Rows[0]["NgayNhap"];


                return phieuNhap;
            }
        }

        public Boolean insert(PhieuNhap phieuNhap)
        {
            String query = "insert PhieuNhap(NgayNhap) values( @NgayNhap)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_NgayNhap = new SqlParameter("NgayNhap", phieuNhap.NgayNhap);

            sqlParameters.Add(param_NgayNhap);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(PhieuNhap phieuNhap)
        {

            String query = "delete from PhieuNhap where MaPhieuNhap = @MaPhieuNhap";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaPhieuNhap", phieuNhap.MaPhieuNhap);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(PhieuNhap phieuNhap)
        {

            String query = "update PhieuNhap set NgayNhap = @NgayNhap where MaPhieuNhap = @MaPhieuNhap";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param_MaPhieuNhap = new SqlParameter("MaPhieuNhap", phieuNhap.MaPhieuNhap);
            SqlParameter param_NgayNhap = new SqlParameter("NgayNhap", phieuNhap.NgayNhap);
            sqlParameters.Add(param_MaPhieuNhap);
            sqlParameters.Add(param_NgayNhap);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        
    }
}
