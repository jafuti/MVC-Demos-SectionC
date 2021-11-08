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
        //Returnng student Name
        public ActionResult getbyName(int stdId)
        {
            var students = new[]
            {
               new{stdId=101, Name ="Abebe"},
                new{stdId=102, Name ="Kebede"},
            };
            string studentName = null;
            foreach (var item in students)
            {
                if (item.stdId == stdId)
                {
                    studentName = item.Name;
                }
            }
            return Content(studentName, "text/plain");
       }
    

    //Reurning Pdf file instead of View
    public ActionResult File()
        {
            string path = "~/Resume" + ".pdf";
            return File(path, "Application/pdf");
        }

        public ActionResult FCB()
        {
            string url = "http://www.facebook.com";
            return Redirect(url);
        }

    //Passing data to view using ViewBag 

        public ActionResult student()
        {
            ViewBag.Id = 101;
            ViewBag.Name = "jafar";
            ViewBag.Grade = 3.0;
            ViewBag.Semester = 4;
            ViewBag.Student = new List<String>()
            {
                "Abebe","Kedir"
            };
            return View();
        }
    }
}