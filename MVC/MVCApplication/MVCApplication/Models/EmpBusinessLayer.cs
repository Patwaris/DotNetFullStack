using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseLayer;

namespace MVCApplication.Models
{
    public class EmpBusinessLayer
    {
        public EmpInfo GetById(int empID)
        {
            EmpData objempdata = new EmpData();
            objempdata.GetEmpDateaFromSQl();
            
            EmpInfo _empInfo = new EmpInfo()
            {
                EmpId = empID,
                Name = "Tes123",
                Dept = "IT",
            };
            return _empInfo;
        }

        public void GetCustInfo()
        {
            //Implementation
        }

        
    }
}