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
    public class QuyDinhDAO
    {
        private DataProvider dp;

        public QuyDinhDAO()
        {
            dp = new DataProvider();
        }

        public List<QuyDinh> getAll()
        {
            String query = "select MaQuyDinh,TenQuyDinh,GiaTri from QuyDinh";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<QuyDinh> lstQuyDinh = new List<QuyDinh>();
            foreach (DataRow dr in dt.Rows)
            {
                QuyDinh quyDinh = new QuyDinh();
                quyDinh.MaQuyDinh = (int)dr["MaQuyDinh"];
                quyDinh.TenQuyDinh = dr["TenQuyDinh"].ToString();
                quyDinh.GiaTri = (int)dr["GiaTri"];


                lstQuyDinh.Add(quyDinh);
            }
            return lstQuyDinh;
        }

        public QuyDinh getByID(int MaQuyDinh)
        {

            String query = "select MaQuyDinh TenQuyDinh,GiaTri from QuyDinh where MaQuyDinh = @MaQuyDinh";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaQuyDinh", MaQuyDinh);
            sqlParameters.Add(param);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                QuyDinh quyDinh = new QuyDinh();
                quyDinh.MaQuyDinh = (int)dt.Rows[0]["MaQuyDinh"];
                quyDinh.TenQuyDinh = dt.Rows[0]["TenQuyDinh"].ToString();
                quyDinh.GiaTri = (int)dt.Rows[0]["GiaTri"];


                return quyDinh;
            }
        }

        public Boolean insert(QuyDinh quyDinh)
        {

            String query = "insert into QuyDinh(TenQuyDinh,GiaTri) values(@TenQuyDinh, @GiaTri)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_TenQuyDinh = new SqlParameter("TenQuyDinh", quyDinh.TenQuyDinh);
            SqlParameter param_GiaTri = new SqlParameter("GiaTri", quyDinh.TenQuyDinh);
            sqlParameters.Add(param_TenQuyDinh);
            sqlParameters.Add(param_GiaTri);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(QuyDinh quyDinh)
        {

            String query = "delete from QuyDinh where MaQuyDinh = @MaQuyDinh";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaQuyDinh", quyDinh.MaQuyDinh);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(QuyDinh quyDinh)
        {

            String query = "update QuyDinh set GiaTri = @GiaTri where MaQuyDinh = @MaQuyDinh";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_GiaTri = new SqlParameter("GiaTri", quyDinh.GiaTri);
            sqlParameters.Add(param_GiaTri);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        
    }
}
