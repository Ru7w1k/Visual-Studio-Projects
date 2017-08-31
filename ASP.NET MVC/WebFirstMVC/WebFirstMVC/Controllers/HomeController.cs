﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFirstMVC.Models;

namespace WebFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmpView()
        {
            Employee emp = new Employee();
            emp.EmpId = 101;
            emp.Name = "Employee";
            emp.Salary = 50000;
            return View(emp);
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