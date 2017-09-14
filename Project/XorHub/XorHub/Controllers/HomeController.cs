﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XorHub.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Student()
        {
            if (Session["username"] == null || Session["usertype"] == null)
            {
                return RedirectToRoute(new
                {
                    controller = "Index",
                    action = "Index",
                    id = 1
                });
            }

            if (!Session["usertype"].Equals("S"))
            {
                return RedirectToRoute(new
                {
                    controller = "Index",
                    action = "Index",
                    id = 2
                });
            }

            return View();
        }

        public ActionResult Teacher()
        {
            if (Session["username"] == null || Session["usertype"] == null)
            {
                return RedirectToRoute(new
                {
                    controller = "Index",
                    action = "Index",
                    id = 1
                });
                //return RedirectToAction("Index", "Index", 1);
            }

            if (!Session["usertype"].Equals("T"))
            {
                return RedirectToRoute(new
                {
                    controller = "Index",
                    action = "Index",
                    id = 2
                });
                //return RedirectToAction("Index", "Index", 2);
            }

            return View();
        }
    }
}