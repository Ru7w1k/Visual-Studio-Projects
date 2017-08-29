using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int DeptNo { get; set; }
    }


    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }

}
