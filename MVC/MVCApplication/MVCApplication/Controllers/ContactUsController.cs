using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index(int empId)
        {
            EmpBusinessLayer objemp_BL = new EmpBusinessLayer();
            EmpInfo empInfo=objemp_BL.GetById(empId);
            return View(empInfo);
        }

        public ActionResult SampleActionMethod()
        {
            return Content("Test");
        }
    }
}