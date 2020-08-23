using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        public SqlConnection connection { get; set; }

        public DataProvider()
        {
            String sConnectString = ConfigurationManager.ConnectionStrings["QuanLyNhaSachDB"].ConnectionString.ToString();
            this.connection = new SqlConnection(sConnectString);
        }

        /*
         * C = CREATE = INSERT ==> ExecuteNonQuery()
         * R = READ   = SELECT ==> Return data ==> ExecuteQuery() ==> DataTable
         * U = UPDATE = UPDATE ==> ExecuteNonQuery()
         * D = DELETE = DELETE ==> ExecuteNonQuery()
         */

        //Command: SELECT
        public DataTable ExecuteQuery(String query, List<SqlParameter> parameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                //Ket noi DB
                this.connection.Open();

                //cau lenh query
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.CommandType = CommandType.Text;  //cau lenh query -> Text, hoac Procedure

                if (parameters != null)
                {
                    //Cau lenh query co parameters
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                //tao moi 1 sql adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //truyen du lieu vao DataTable dt
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                //throw new Exception("Error execute query: " + ex.Message);
                Console.WriteLine("Error execute query: " + ex.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return dt;
        }

        //Command: INSERT/ UPDATE/ DELETE
        public bool ExecuteNonQuery(String query, List<SqlParameter> parameters = null)
        {
            bool flag = true;

            try
            {
                //ket noi DB
                this.connection.Open();

                //cau lenh query
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.CommandType = CommandType.Text;  //cau lenh query -> Text, hoac Procedure

                if (parameters != null)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                //thuc hien nonQuery
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                flag = false;
                //throw new Exception("Error execute non query: " + ex.Message);
                Console.WriteLine("Error execute non query: " + ex.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return flag;
        }
    }
}
