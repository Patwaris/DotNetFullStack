using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmptyWebApp
{
    public class EmployeeHelper
    {
        public string GetEmpName()
        {
            string empName = "";
            DataTable dt = new DataTable();

            string Select_Query = "SELECT EmpName FROM [dbo].[Employee] where EmpNumber='Emp1'";
            DBClass objDb = new DBClass();
            SqlConnection Conn = objDb.GetConnection();
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(Select_Query, Conn);

                //The follwoing code uses the sql Adapter to fill the data into the datatable or Data set
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                empName = dt.Rows[0][0].ToString();

                //UnComment this to read the data  using the SQL Data Reader

                //SqlDataReader sdr = cmd.ExecuteReader();

                //while (sdr.Read())
                //{
                //    empName = sdr["EmpName"].ToString();
                //}
            }
            catch (Exception ex)
            {
                //Logs the data
            }
            finally
            {
                Conn.Close();
            }
            return empName;
        }
    }
}