using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public class Employee
    {
        int empId;
        string empName;
        string empDesc;

        public Employee(int _empId, string _empName, string _empDesc)
        {
            empId = _empId;
            empName = _empName;
            empDesc = _empDesc;
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("");
        }

        public void Display()
        {
            Console.WriteLine("Employee {0} : {1} , {2}", empId, empName, empDesc);
        }
    }

    public class Developer : Employee
    {
        int salary;

        public Developer(int _empId, string _empName, string _empDesc, int _salary) : base(_empId, _empName, _empDesc)
        {
            salary = _salary;
        }

        public override void CalculateSalary()
        {
            Display();
            Console.WriteLine("Salary : {0}", salary * 5);
        }
    }

    public class LabAssistant : Employee
    {
        int salary;

        public LabAssistant(int _empId, string _empName, string _empDesc, int _salary) : base(_empId, _empName, _empDesc)
        {
            salary = _salary;
        }

        public override void CalculateSalary()
        {
            Display();
            Console.WriteLine("Salary : {0}", salary * 2);
        }
    }

    public class Manager : Employee
    {
        int salary;

        public Manager(int _empId, string _empName, string _empDesc, int _salary) : base(_empId, _empName, _empDesc)
        {
            salary = _salary;
        }

        public override void CalculateSalary()
        {
            Display();
            Console.WriteLine("Salary : {0}", salary * 7);
        }
    }
}