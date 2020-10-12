using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmptyWebApp
{
    public class DBClass
    {
        string ConnString= ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public SqlConnection GetConnection()
        {
            SqlConnection _conn = new SqlConnection(ConnString);
            return _conn;
        }
    }
}