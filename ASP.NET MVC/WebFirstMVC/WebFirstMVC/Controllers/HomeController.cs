using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFirstMVC.Models;
using WebFirstMVC.ModelView;

namespace WebFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("JSON")]
        public JsonResult MyIndex()
        {
            Employee emp = new Employee();
            emp.EmpId = 101;
            emp.Name = "Test";
            emp.Salary = 5000;

            return Json(emp, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EmpView()
        {
            Employee emp = new Employee();
            emp.EmpId = 101;
            emp.Name = "Employee";
            emp.Salary = 50000;
            return View(emp);
        }

        public string PostAction(string btnSubmit, string txtName)
        {
            return txtName + " " + btnSubmit;            
        }

        public ActionResult EmployeeView()
        {
            Employee emp = new Employee() { EmpId = 101, Name = "test", Salary = 200 };
            EmployeeView empView = new ModelView.EmployeeView();
            empView.Name = emp.Name;
            return View(empView);
        }
        
        [ActionName("CurrentTime")]
        public ActionResult GetCurrentTime()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();

            return View("CurrentTime");
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