using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ювелирная_мастерская
{

    public static class DataBaseWork
    {
        public static string connectString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=jewerly_workshop;Integrated Security=True";
        public static SqlConnection Con;

        public static void OpenCon()
        {
            Con = new SqlConnection(connectString);
            Con.Open();
        }

        public static void CloseConnection()
        {
            Con.Close();
        }

        public static DataTable Load(string SqlQuery)
        {
            OpenCon();
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand(SqlQuery, Con);
            query.CommandType = CommandType.Text;
            SqlDataReader dr = query.ExecuteReader();
            dt.Load(dr);
            CloseConnection();
            return dt;
        }
    }
}
