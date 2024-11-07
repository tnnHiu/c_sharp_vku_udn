using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseConnection
    {
        protected string connString = "Data Source=TNN-HIU-LEGION-;Initial Catalog=STUDENT_MANAGEMENT;User ID=tnnh;Encrypt=True;TrustServerCertificate=True";
        protected SqlConnection? conn;
        public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connString);
            }
            if (conn.State == System.Data.ConnectionState.Closed) { conn.Open(); }
        }
        public void CloseConnection()
        {
            if (conn!.State == System.Data.ConnectionState.Open) { conn.Close(); }
        }

    }
}

