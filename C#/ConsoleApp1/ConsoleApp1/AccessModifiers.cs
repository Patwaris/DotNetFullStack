using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccessModifiers
    {
        public  void GetEmpName()
        {
            //Write the code to get the name from the database
            string emp_Name = "ABC";
        }

        private void GetDeptName()
        {
            GetEmpName();
        }
    }
}
