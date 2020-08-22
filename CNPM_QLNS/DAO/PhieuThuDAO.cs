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
    public class PhieuThuDAO
    {
        private DataProvider dp;

        public PhieuThuDAO()
        {
            dp = new DataProvider();
        }

        public List<PhieuThu> getAll()
        {
            String query = "select MaPhieuThu,NgayThuTien,SoTienThu from PhieuThu";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<PhieuThu> lstPhieuThu = new List<PhieuThu>();
            foreach (DataRow dr in dt.Rows)
            {
                PhieuThu phieuThu = new PhieuThu();
                phieuThu.MaPhieuThu = (int)dr["MaPhieuThu"];
                phieuThu.NgayThuTien = (DateTime)dr["NgayThuTien"];
                phieuThu.SoTienThu = (Decimal)dr["SoTienThu"];


                lstPhieuThu.Add(phieuThu);
            }
            return lstPhieuThu;
        }

        public PhieuThu getByID(int MaPhieuThu)
        {

            String query = "select MaPhieuThu NgayThuTien,SoTienThu from PhieuThu where MaPhieuThu = @MaPhieuThu";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaPhieuThu", MaPhieuThu);
            sqlParameters.Add(param);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                PhieuThu phieuThu = new PhieuThu();
                phieuThu.MaPhieuThu = (int)dt.Rows[0]["MaPhieuThu"];
                phieuThu.NgayThuTien = (DateTime)dt.Rows[0]["NgayThuTien"];
                phieuThu.SoTienThu = (Decimal)dt.Rows[0]["SoTienThu"];



                return phieuThu;
            }
        }

        public Boolean insert(PhieuThu phieuThu)
        {

            String query = "insert PhieuThu(NgayThuTien,SoTienThu) values(@NgayThuTien, @SoTienThu)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_NgayThuTien = new SqlParameter("NgayThuTien", phieuThu.NgayThuTien);
            SqlParameter param_SoTienThu = new SqlParameter("SoTienThu", phieuThu.SoTienThu);

            sqlParameters.Add(param_NgayThuTien);
            sqlParameters.Add(param_SoTienThu);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(PhieuThu phieuThu)
        {

            String query = "delete from PhieuThu where MaPhieuThu = @MaPhieuThu";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaPhieuThu", phieuThu.MaPhieuThu);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(PhieuThu phieuThu)
        {

            String query = "update PhieuThu set NgayThuTien = @NgayThuTien, SoTienThu = @SoTienThu where MaPhieuThu = @MaPhieuThu";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_NgayThuTien = new SqlParameter("NgayThuTien", phieuThu.NgayThuTien);
            SqlParameter param_SoTienThu = new SqlParameter("SoTienThu", phieuThu.SoTienThu);
            SqlParameter param_MaPhieuThu = new SqlParameter("MaPhieuThu", phieuThu.MaPhieuThu);

            sqlParameters.Add(param_NgayThuTien);
            sqlParameters.Add(param_SoTienThu);
            sqlParameters.Add(param_MaPhieuThu);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        
    }
}
