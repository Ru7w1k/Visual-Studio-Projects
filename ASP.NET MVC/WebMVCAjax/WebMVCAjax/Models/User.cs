using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMVCAjax.Models
{
    public class User
    {
        [Key]
        [Display(Name = "User Code")]
        public string UserCode { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
    }

    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}