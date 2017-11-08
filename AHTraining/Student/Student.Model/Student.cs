using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    public class Stud
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Branch { get; set; }
        public int Year { get; set; }
    }
}
