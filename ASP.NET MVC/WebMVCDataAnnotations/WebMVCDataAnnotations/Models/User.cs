using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMVCDataAnnotations.Models
{
    public class User
    {
        [Key]
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9][a-zA-Z0-9_]*$", ErrorMessage = "Invalid username (it should contain only alphanumeric characters")]
        public string UserName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Password should contain atleast 8 characters.")]
        public string Password { get; set; }

        //[NotMapped]
        //[Compare("Password")]
        //public string ConfirmPassword { get; set; }

        //[Required]
        //public string Name { get; set; }

        //[RegularExpression(@"^[789][0-9]{9,9}$")]
        //public string Mobile { get; set; }

        //[RegularExpression(@"^[a-zA-Z0-9_]+[@][a-zA-Z]+\.[a-zA-Z]+$")]
        //public string Email { get; set; }
    }
}