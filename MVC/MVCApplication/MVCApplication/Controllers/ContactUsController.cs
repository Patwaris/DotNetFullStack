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
            EmpInfo empInfo = objemp_BL.GetById(empId);
            ViewBag.LoginUser = empInfo.Name;
            ViewData["EmpInformation"] = empInfo;
            return View(empInfo);
        }

        public ActionResult ActionMethod1()
        {
            TempData["EmpName"] = "Test Name";
            return Content("Test");
        }

        public ActionResult ActionMethod2()
        {
            string _empName = TempData["EmpName"].ToString();
            TempData.Keep();
            return Content(_empName);
        }

        public ActionResult ActionMethod3()
        {
            string _empName = TempData["EmpName"].ToString();
            TempData.Keep();
            return Content(_empName);
        }
        public string Insert(EmpInfo emp)
        {
            string _name = emp.Name;
            _name = Request["Name"];
            return _name;
        }

    }
}