using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebMVCGlobalization.LocalResource;

namespace WebMVCGlobalization.Models
{
    public class User
    {
        [Display(Name = "Username", ResourceType = typeof(Resource))]
        public string FirstName { get; set; }

        [Display(Name = "Password", ResourceType = typeof(Resource))]
        public string LastName { get; set; }
    }
}