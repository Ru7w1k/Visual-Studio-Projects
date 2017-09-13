using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XorHub.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            using (XorHubEntities db = new XorHubEntities())
            {
                List<SelectListItem> list = new List<SelectListItem>();
                foreach (var item in db.Batches)
                {
                    list.Add(new SelectListItem { Text = item.Name, Value = item.BatchId.ToString() });
                }
                
                ViewData["BatchList"] = list;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Register(LoginInfo model)
        {


            if(!ModelState.IsValid)
            {
                return View("Index", model);
            }

            using (XorHubEntities db = new XorHubEntities())
            {
                db.LoginInfoes.Add(model);
                db.SaveChanges();
            }

            ViewBag.Message = "User Registered Successfully!!";
            return View("Index");
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            return View();
        }



            //                if(model.Usertype.Equals("T") && !model.Stat)
            //        {
            //            ViewBag.Message = "User Not Authorized! Contact Admin..";
            //            return View("Index");
            //}
        }
}