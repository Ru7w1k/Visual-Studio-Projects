using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDBFromCode
{
    public class DepartmentContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(u => u.Name).HasColumnName("DeptName");
        }

    }
}
