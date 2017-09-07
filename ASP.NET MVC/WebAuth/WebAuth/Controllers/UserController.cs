using System;
using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebAuth.Models;

namespace WebAuth.Controllers
{
    public class UserController : Controller
    {
        public string ClaimsType { get; private set; }

        // GET: User
        [AllowAnonymous]
        public ActionResult Index()
        {
            //using (UserModelContext db = new UserModelContext())
            //{
            //    db.Users.Add(new UserModel() { UserName = "test", Password = "test1234", Type = UserType.User });
            //    db.Users.Add(new UserModel() { UserName = "admin", Password = "admin1234", Type = UserType.Admin });

            //    db.SaveChanges();
            //}

            return View();
        }
        

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(UserModel user)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", user);
            }

            using (UserModelContext db = new UserModelContext())
            {
                var users = db.Users.Where(u => u.UserName == user.UserName && u.Password == u.Password);

                if(users.Count() > 0)
                {
                    AuthenticationManager.Sign
                    return RedirectToAction("Home", "User", users.First());
                }
            }
            return View(user);
        }

        [Authorize(Users = "test")]
        public ActionResult Home(UserModel user)
        {
            return View();
        }
    }
}