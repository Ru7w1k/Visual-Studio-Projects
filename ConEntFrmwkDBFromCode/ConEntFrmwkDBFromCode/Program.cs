using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDBFromCode;

namespace ConEntFrmwkDBFromCode
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var DeptObj = new DepartmentContext())
            {
                Console.WriteLine("Add Department");
                var deptObj = new Department { Id = 2, Name = "IT", Location = "Pune", AddURL="test.com" };
                DeptObj.Departments.Add(deptObj);
                DeptObj.SaveChanges();

                Console.WriteLine("Added Department");
            }

            Console.ReadLine();
        }
    }
}
