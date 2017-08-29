using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConEntityFramework;

namespace ConDataFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new TestDatabaseEntities())
            {
                //var emp = new Employee();
                //emp.EmpId = 41;
                //emp.Name = "Emp1";
                //emp.Salary = 10000;
                //EmpObj.Employees.Add(emp);

                //emp = new Employee();
                //emp.EmpId = 21;
                //emp.Name = "Emp2";
                //emp.Salary = 50000;
                //EmpObj.Employees.Add(emp);

                //emp = new Employee();
                //emp.EmpId = 31;
                //emp.Name = "Emp3";
                //emp.Salary = 40000;
                //EmpObj.Employees.Add(emp);

                //emp = new Employee();
                //emp.EmpId = 410;
                //emp.Name = "Emp4";
                //emp.Salary = 80000;
                //EmpObj.Employees.Add(emp);

                //EmpObj.SaveChanges();

                var emps = EmpObj.Employees;
                foreach (var emp in emps)
                {
                    Console.WriteLine(emp.EmpId + " " + emp.Name + " " + emp.Salary);
                }
            }
            
            Console.ReadLine();
        }
    }
}
