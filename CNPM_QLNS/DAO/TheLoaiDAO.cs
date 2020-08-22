using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TheLoaiDAO
    {
        private DataProvider dp;

        public TheLoaiDAO()
        {
            dp = new DataProvider();
        }

        public List<TheLoai> getAllReturnList()
        {
            String query = "select MaTheLoai,TenTheLoai from TheLoai";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<TheLoai> lstTheLoai = new List<TheLoai>();
            foreach (DataRow dr in dt.Rows)
            {
                TheLoai theLoai = new TheLoai();
                theLoai.MaTheLoai = (int)dr["MaTheLoai"];
                theLoai.TenTheLoai = dr["TenTheLoai"].ToString();

                lstTheLoai.Add(theLoai);
            }
            return lstTheLoai;
        }

        public DataTable getAllReturnDataTable()
        {
            String query = "select MaTheLoai as [Mã thể loại], TenTheLoai as [Tên thể loại] from TheLoai";
            DataTable dt = this.dp.ExecuteQuery(query);

            return dt;
        }

        public TheLoai getByID(int MaTheLoai)
        {

            String query = "select MaTheLoai,TenTheLoai from TheLoai where MaTheLoai = @MaTheLoai";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaTheLoai", MaTheLoai);
            sqlParameters.Add(param);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                TheLoai theLoai = new TheLoai();
                theLoai.MaTheLoai = (int)dt.Rows[0]["MaTheLoai"];
                theLoai.TenTheLoai = dt.Rows[0]["TenTheLoai"].ToString();


                return theLoai;
            }
        }

        public TheLoai getByTenTheLoai(String TenTheLoai)
        {

            String query = "select MaTheLoai, TenTheLoai from TheLoai where TenTheLoai = @TenTheLoai";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("TenTheLoai", TenTheLoai);
            sqlParameters.Add(param);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                TheLoai theLoai = new TheLoai();
                theLoai.MaTheLoai = (int)dt.Rows[0]["MaTheLoai"];
                theLoai.TenTheLoai = dt.Rows[0]["TenTheLoai"].ToString();

                return theLoai;
            }
        }

        public Boolean insert(TheLoai theLoai)
        {

            String query = "insert TheLoai(TenTheLoai) values(@TenTheLoai)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_TenTheLoai = new SqlParameter("TenTheLoai", theLoai.TenTheLoai);


            sqlParameters.Add(param_TenTheLoai);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(TheLoai theLoai)
        {

            String query = "delete from TheLoai where MaTheLoai = @MaTheLoai";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaTheLoai", theLoai.MaTheLoai);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(TheLoai theLoai)
        {

            String query = "update TheLoai set TenTheLoai = @TenTheLoai where MaTheLoai = @MaTheLoai";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_TenTheLoai = new SqlParameter("TenTheLoai", theLoai.TenTheLoai);
            SqlParameter param_MaTheLoai = new SqlParameter("MaTheLoai", theLoai.MaTheLoai);

            sqlParameters.Add(param_TenTheLoai);
            sqlParameters.Add(param_MaTheLoai);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }


    }
}