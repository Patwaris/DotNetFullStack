using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public string GetEmpName(string LastName)
        {
            if (LastName == "Patwari")
                return "Patwari Bharath";
            else
                return "I can not find the name with this last name";
        }

    }
}