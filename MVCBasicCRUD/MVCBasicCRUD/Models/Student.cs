using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBasicCRUD.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int RollNo { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Marks { get; set; }
    }
}