using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCDataAnnotations.Models;

namespace WebMVCDataAnnotations.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult DoRegister(UserDetails user)
        {            
            if(!ModelState.IsValid)
            {
                return View("register", user);
            }
            using (UserContext usrDB = new UserContext())
            {
                usrDB.Users.Add(user);
                usrDB.SaveChanges();
            }

            return View("login");
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult DoLogin(User user)
        {
            if(!ModelState.IsValid)
            {
                return View("login", user);
            }

            using (UserContext usrDB = new UserContext())
            {
                if(usrDB.Users.Any(u => u.UserName.Equals(user.UserName) && u.Password.Equals(user.Password)))
                {

                    return View("home", user);
                }
            }
            return View("login", user);           
        }

        [Authorize]
        public ActionResult Home(User user)
        {
            return View(user);
        }
    }
}