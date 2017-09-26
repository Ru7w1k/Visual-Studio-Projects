using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //XorHubEntities xh = new XorHubEntities();
            //var data = xh.LoginInfoes.ToList();
            StudEntities obj = new StudEntities();
            obj.StudInfoes.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}