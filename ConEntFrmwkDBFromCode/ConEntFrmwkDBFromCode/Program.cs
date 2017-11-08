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
                //Console.WriteLine("Add Department");
                //var deptObj = new Department { Id = 2, Name = "IT", Location = "Pune", AddURL="test.com" };
                //DeptObj.Departments.Add(deptObj);
                //DeptObj.SaveChanges();

                //Console.WriteLine("Added Department");
                List<Department> depts = DeptObj.Departments.ToList();

                var dept = DeptObj.Departments.Where(d => d.Id == 2).FirstOrDefault();

                dept = new Department { Name="Modified"};
                //dept.Name = "Updated!";
                DeptObj.SaveChanges();

                depts = DeptObj.Departments.ToList();
            }

            Console.ReadLine();
        }
    }
}
