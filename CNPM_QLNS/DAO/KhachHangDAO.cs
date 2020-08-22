using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class KhachHangDAO
    {
        private DataProvider dp;

        public KhachHangDAO()
        {
            dp = new DataProvider();
        }

        public List<KhachHang> getAll()
        {
            String query = "select MaKhachHang,HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi from KhachHang";
            DataTable dt = this.dp.ExecuteQuery(query);

            List<KhachHang> lstKhachHang = new List<KhachHang>();
            foreach (DataRow dr in dt.Rows)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.MaKhachHang = (int)dr["MaKhachHang"];
                khachHang.HoTen = dr["HoTen"].ToString();
                khachHang.DiaChi = dr["DiaChi"].ToString();
                khachHang.DienThoai = dr["DienThoai"].ToString();
                khachHang.SoTienNoDau = (Decimal)dr["SoTienNoDau"];
                khachHang.SoTienNoCuoi = (Decimal)dr["SoTienNoCuoi"];

                lstKhachHang.Add(khachHang);
            }
            return lstKhachHang;
        }

        public KhachHang getByID(int MaKhachHang)
        {

            String query = "select MaKhachHang,HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi from KhachHang where MaKhachHang = @MaKhachHang";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("MaKhachHang", MaKhachHang);
            sqlParameters.Add(param);
            DataTable dt = this.dp.ExecuteQuery(query, sqlParameters);
            if (dt.Rows.Count == 0)
                return null;
            else
            {
                KhachHang khachHang = new KhachHang();
                khachHang.MaKhachHang = (int)dt.Rows[0]["MaKhachHang"];
                khachHang.HoTen = dt.Rows[0]["HoTen"].ToString();
                khachHang.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                khachHang.DienThoai = dt.Rows[0]["DienThoai"].ToString();
                khachHang.SoTienNoDau = (Decimal)dt.Rows[0]["SoTienNoDau"];
                khachHang.SoTienNoCuoi = (Decimal)dt.Rows[0]["SoTienNoCuoi"];

                return khachHang;
            }
        }

        public Boolean insert(KhachHang khachHang)
        {

            String query = "insert KhachHang(HoTen,DiaChi,DienThoai,SoTienNoDau,SoTienNoCuoi) values(@HoTen, @DiaChi, @DienThoai, @SoTienNoDau, @SoTienNoCuoi)";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_HoTen = new SqlParameter("HoTen", khachHang.HoTen);
            SqlParameter param_DiaChi = new SqlParameter("DiaChi", khachHang.DiaChi);
            SqlParameter param_DienThoai = new SqlParameter("DienThoai", khachHang.DienThoai);
            SqlParameter param_SoTienNoDau = new SqlParameter("SoTienNoDau", khachHang.SoTienNoDau);
            SqlParameter param_SoTienNoCuoi = new SqlParameter("SoTienNoCuoi", khachHang.SoTienNoCuoi);
            sqlParameters.Add(param_HoTen);
            sqlParameters.Add(param_DiaChi);
            sqlParameters.Add(param_DienThoai);
            sqlParameters.Add(param_SoTienNoDau);
            sqlParameters.Add(param_SoTienNoCuoi);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean delete(KhachHang khachHang)
        {

            String query = "delete from KhachHang where MaKhachHang = @MaKhachHang";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("MaKhachHang", khachHang.MaKhachHang);
            sqlParameters.Add(parameter);
            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }

        public Boolean update(KhachHang khachHang)
        {

            String query = "update KhachHang set HoTen = @HoTen, DiaChi = @DiaChi, DienThoai = @DienThoai, SoTienNoDau = @SoTienNoDau, SoTienNoCuoi = @SoTienNoCuoi where MaKhachHang = @MaKhachHang";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();

            SqlParameter param_HoTen = new SqlParameter("HoTen", khachHang.HoTen);
            SqlParameter param_DiaChi = new SqlParameter("DiaChi", khachHang.DiaChi);
            SqlParameter param_DienThoai = new SqlParameter("DienThoai", khachHang.DienThoai);
            SqlParameter param_SoTienNoDau = new SqlParameter("SoTienNoDau", khachHang.SoTienNoDau);
            SqlParameter param_SoTienNoCuoi = new SqlParameter("SoTienNoCuoi", khachHang.SoTienNoCuoi);
            SqlParameter param_MaKhachHang = new SqlParameter("HoTen", khachHang.MaKhachHang);

            sqlParameters.Add(param_HoTen);
            sqlParameters.Add(param_DiaChi);
            sqlParameters.Add(param_DienThoai);
            sqlParameters.Add(param_SoTienNoDau);
            sqlParameters.Add(param_SoTienNoCuoi);
            sqlParameters.Add(param_MaKhachHang);

            return this.dp.ExecuteNonQuery(query, sqlParameters);
        }


    }
}
