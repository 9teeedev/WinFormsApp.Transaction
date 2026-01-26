using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WinFormsApp.Transaction
{
    internal class DBConnect
    {
        public static SqlConnection Company_DB_Connect()
        {
            string strCon = "Data Source=9TEEDEV\\SQLEXPRESS; Initial Catalog=Company_DB; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            return conn;
        }
    }
}
