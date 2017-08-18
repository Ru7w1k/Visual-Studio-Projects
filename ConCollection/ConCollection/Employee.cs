using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollection
{
    public class Employee
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        public Employee(string empId, string empName, double salary)
        {
            EmpID   = empId;
            EmpName = empName;
            Salary  = salary;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nName: {1}\nSalary: {2}", EmpID, EmpName, Salary);
        }

    }
}
