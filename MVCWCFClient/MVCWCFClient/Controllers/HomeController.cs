using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWCFClient.EmployeeServiceReference;

namespace MVCWCFClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Employee[] emp;
            Department dept;

            EmployeeServiceClient client = new EmployeeServiceClient();
            ViewBag.Message = client.GetEmployeeDetails("Admin", 101, 1, out dept, out emp);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}