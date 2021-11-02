using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDEMOSECTIONC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View("Contact");
        }
        public ActionResult GetStudentName(int stdId)
        {
            var students = new[]
            {
              new {stdId=101, Name="Abebe"},
              new {stdId=102, Name="Kebede"},
          };
            string studentName = null;
            foreach(var item in students)
            {
                if (item.stdId == stdId)
                {
                    studentName = item.Name;
                }
            }
            return Content(studentName, "text/plain");
        }
    }
}