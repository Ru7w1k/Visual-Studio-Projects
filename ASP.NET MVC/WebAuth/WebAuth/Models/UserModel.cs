using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAuth.Models
{
    public enum UserType
    {
        Admin,
        User        
    }

    public class UserModel
    {
        [Key]
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Type")]
        [EnumDataType(typeof(UserType))]
        public UserType Type { get; set; }
    }

    public class UserModelContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
    }
}