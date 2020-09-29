using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI.Controllers
{
    public class EmpController : ApiController
    {
        //GET:api/Emp/1
        [HttpGet]
        public string GetEmpName(int id)
        {
            string name = "";
            if (id == 1)
            {
                name = "Test123";
            }
            else
            {
                name = "Test321";
            }

            return name;
        }

        //POST
        //PUT
        //DELETE
    }
}
