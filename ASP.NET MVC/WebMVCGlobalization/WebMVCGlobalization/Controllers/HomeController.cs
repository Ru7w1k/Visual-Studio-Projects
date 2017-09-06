using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCGlobalization.Helper;
using WebMVCGlobalization.Models;

namespace WebMVCGlobalization.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {

            return View(new User() { FirstName = "TEst", LastName = "Last NAme"});
        }
        
        public ActionResult ChangeCurrentCulture(int id)
        {
            //  
            // Change the current culture for this user.  
            //  
            CultureHelper.CurrentCulture = id;
            //  
            // Cache the new current culture into the user HTTP session.   
            //  
            Session["CurrentCulture"] = id;
            //  
            // Redirect to the same page from where the request was made!   
            //  
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}