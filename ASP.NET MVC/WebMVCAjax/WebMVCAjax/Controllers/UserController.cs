using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCAjax.Models;

namespace WebMVCAjax.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            //using (var db = new UserContext())
            //{
            //    db.Users.AddRange(
            //        new User[]
            //        {
            //            new Models.User { UserCode = "101", UserName = "usr1"},
            //            new Models.User { UserCode = "102", UserName = "test"},
            //            new Models.User { UserCode = "103", UserName = "admin"},
            //            new Models.User { UserCode = "104", UserName = "default"},
            //        });
            //    db.SaveChanges();

            //}
                return View(new UserBinding() { user = new Models.User(), users = new List<Models.User>()});
        }

        public ActionResult GetAllUsers()
        {
            List<User> users = new List<User>();
            using (var db = new UserContext())
            {
                users = db.Users.ToList();
            }
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SearchUsers(string username)
        {
            List<User> users = new List<User>();
            using (var db = new UserContext())
            {
                users = db.Users.Where(u => u.UserName.Contains(username)).ToList();
            }
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}