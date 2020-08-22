using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAO
{
    public class SachDAO
    {
        private DataProvider dp;

        public SachDAO()
        {
            dp = new DataProvider();
        }

        public List<Sach> getAll()
        {
            String query = "select MaSach,TenSach,MaTheLoai,TacGia,SoLuongTonDau,SoLuongTonCuoi,DonGia  from Sach";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<Sach> lstSach = new List<Sach>();
            foreach (DataRow dr in dt.Rows)
            {
                Sach sach = new Sach();
                sach.MaSach = (int)dr["MaSach"];
                sach.TenSach = dr["TenSach"].ToString();
                sach.MaTheLoai = (int)dr["MaTheLoai"];
                sach.TacGia = dr["TacGia"].ToString();
                sach.SoLuongTonDau = (int)dr["SoLuongTonDau"];
                sach.SoLuongTonCuoi = (int)dr["SoLuongTonCuoi"];
                sach.DonGia = (Decimal)dr["DonGia"];

                lstSach.Add(sach);
            }
            return lstSach;
        }

        public DataTable getAllForDgvSach()
        {
            StringBuilder query = new StringBuilder("select s.MaSach as [Mã sách]");
            query.Append(", s.TenSach as [Tên sách]");
            query.Append(", tl.TenTheLoai as [Tên thể loại]");
            query.Append(", s.TacGia as [Tác giả]");
            query.Append(", s.SoLuongTonCuoi as [Lượng tồn]");
            query.Append(", s.DonGia as [Đơn giá]");
            query.Append(" from Sach s");
            query.Append(" inner join TheLoai tl");
            query.Append(" on s.MaTheLoai = tl.MaTheLoai");
            DataTable dt = this.dp.ExecuteQuery(query.ToString());

            return dt;
        }

        public Sach getByID(int MaSach)
        {

            String query = "select MaSach,TenSach,MaTheLoai,TacGia,SoLuongTonDau,SoLuongTonCuoi,DonGia from Sach where MaSach=@MaSach";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaSach", MaSach);
            sqlParameters.Add(param);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                Sach sach = new Sach();
                sach.MaSach = (int)dt.Rows[0]["MaSach"];
                sach.TenSach = dt.Rows[0]["TenSach"].ToString();
                sach.TacGia = dt.Rows[0]["TacGia"].ToString();
                sach.MaTheLoai = (int)dt.Rows[0]["MaTheLoai"];
                sach.SoLuongTonDau = (int)dt.Rows[0]["SoLuongTonDau"];
                sach.SoLuongTonCuoi = (int)dt.Rows[0]["SoLuongTonCuoi"];

                sach.DonGia = (Decimal)dt.Rows[0]["DonGia"];


                return sach;
            }
        }
        public Sach getByThuocTinh(String TenSach, int MaTheLoai, String TacGia)
        {

            String query = "select MaSach,TenSach,MaTheLoai,TacGia,SoLuongTonDau,SoLuongTonCuoi,DonGia  from Sach where TenSach=@TenSach and MaTheLoai=@MaTheLoai and TacGia=@TacGia";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_TenSach = new SqlParameter("TenSach", TenSach);
            sqlParameters.Add(param_TenSach);
            SqlParameter param_MaTheLoai = new SqlParameter("MaTheLoai", MaTheLoai);
            sqlParameters.Add(param_MaTheLoai);
            SqlParameter param_TacGia = new SqlParameter("TacGia", TacGia);
            sqlParameters.Add(param_TacGia);

            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                Sach sach = new Sach();
                sach.MaSach = (int)dt.Rows[0]["MaSach"];
                sach.TenSach = dt.Rows[0]["TenSach"].ToString();
                sach.TacGia = dt.Rows[0]["TacGia"].ToString();
                sach.MaTheLoai = (int)dt.Rows[0]["MaTheLoai"];
                sach.SoLuongTonCuoi = (int)dt.Rows[0]["SoLuongTonCuoi"];
                sach.SoLuongTonDau = (int)dt.Rows[0]["SoLuongTonDau"];
                sach.DonGia = (Decimal)dt.Rows[0]["DonGia"];


                return sach;
            }
        }

        public Boolean insert(Sach sach)
        {

            String query = "insert into Sach(TenSach,MaTheLoai,TacGia,SoLuongTonDau,SoLuongTonCuoi,DonGia) values(@TenSach, @MaTheLoai, @TacGia, @SoLuongTonDau, @SoLuongTonCuoi, @DonGia)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_TenSach = new SqlParameter("TenSach", sach.TenSach);
            SqlParameter param_MaTheLoai = new SqlParameter("MaTheLoai", sach.MaTheLoai);
            SqlParameter param_TacGia = new SqlParameter("TacGia", sach.TacGia);
            SqlParameter param_SoLuongTonDau = new SqlParameter("SoLuongTonDau", sach.SoLuongTonDau);
            SqlParameter param_SoLuongTonCuoi = new SqlParameter("SoLuongTonCuoi", sach.SoLuongTonCuoi);
            SqlParameter param_DonGia = new SqlParameter("DonGia", sach.DonGia);

            sqlParameters.Add(param_TenSach);
            sqlParameters.Add(param_MaTheLoai);
            sqlParameters.Add(param_TacGia);
            sqlParameters.Add(param_SoLuongTonDau);
            sqlParameters.Add(param_SoLuongTonCuoi);
            sqlParameters.Add(param_DonGia);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(Sach sach)
        {

            String query = "delete from Sach where MaSach=@MaSach";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaSach", sach.MaSach);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(Sach sach)
        {

            String query = "update Sach set TenSach = @TenSach, MaTheLoai = @MaTheLoai, TacGia = @TacGia, SoLuongTonCuoi = @SoLuongTonCuoi, DonGia = @DonGia where MaSach = @MaSach";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_TenSach = new SqlParameter("TenSach", sach.TenSach);
            SqlParameter param_MaTheLoai = new SqlParameter("MaTheLoai", sach.MaTheLoai);
            SqlParameter param_TacGia = new SqlParameter("TacGia", sach.TacGia);
            SqlParameter param_SoLuongTonCuoi = new SqlParameter("SoLuongTonCuoi", sach.SoLuongTonCuoi);
            SqlParameter param_DonGia = new SqlParameter("DonGia", sach.DonGia);
            SqlParameter param_MaSach = new SqlParameter("MaSach", sach.MaSach);

            sqlParameters.Add(param_TenSach);
            sqlParameters.Add(param_MaTheLoai);
            sqlParameters.Add(param_TacGia);
            sqlParameters.Add(param_SoLuongTonCuoi);
            sqlParameters.Add(param_DonGia);
            sqlParameters.Add(param_MaSach);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }


    }
}