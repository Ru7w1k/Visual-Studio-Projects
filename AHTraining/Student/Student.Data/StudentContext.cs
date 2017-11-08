using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Model;

namespace Student.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Stud> Students { get; set; }
    }
}
