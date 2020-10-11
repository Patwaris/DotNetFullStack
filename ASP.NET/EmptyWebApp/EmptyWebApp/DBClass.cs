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

        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public SqlConnection GetConnection()
        {
            SqlConnection con = null;
            con = new SqlConnection(connStr);
            return con;
        }
    }
}