using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAdvanceClass
{
    interface IEmployee
    {
        double CalculateSalary();
        void Display();
    }

    public class PartTimeEmp : IEmployee
    {
        public double CalculateSalary()
        {
            Console.WriteLine("Salary of PartTime Emp");
            return 1000;
        }

        public void Display()
        {
            Console.WriteLine("PartTime Employee");
        }

        public void NewMethod()
        {

        }
    }

    public class FullTimeEmp : IEmployee
    {
        public double CalculateSalary()
        {
            Console.WriteLine("Salary of FullTime Emp");
            return 5000;
        }

        public void Display()
        {
            Console.WriteLine("FullTime Employee");
        }
    }

    public class Test : IEmployee
    {
        public double CalculateSalary()
        {
            return 1000;
        }

        double IEmployee.CalculateSalary()
        {
            return 1234546;
        }

        void IEmployee.Display()
        {
            throw new NotImplementedException();
        }
    }
}
