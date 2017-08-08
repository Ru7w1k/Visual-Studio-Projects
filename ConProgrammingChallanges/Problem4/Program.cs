using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee;

            employee = new Developer(101, "dev", "developer", 1000);
            employee.CalculateSalary();

            employee = new LabAssistant(102, "Test", "Lab ASsistant", 2500);
            employee.CalculateSalary();

            employee = new Manager(103, "Sample", "Test Test", 3000);
            employee.CalculateSalary();
        }
    }
}
