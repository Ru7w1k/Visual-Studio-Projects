using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEmployee
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string ProjectName { get; set; }

        public override string ToString()
        {
            return string.Format("\nID: {0}\nName: {1}\nDepartment: {2}\nProject: {3}\n", ID, Name, DepartmentName, ProjectName);
        }

        public Employee(int id, string name, string departmentName, string projectName)
        {
            ID = id;
            Name = name;
            DepartmentName = departmentName;
            ProjectName = projectName;            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(101, "ABC",  "Dev",  "Pro001"));
            employees.Add(new Employee(102, "PQR",  "Dev",  "Pro001"));
            employees.Add(new Employee(103, "XYZ",  "Test", "Pro005"));
            employees.Add(new Employee(104, "Rut",  "Dev",  "Pro005"));
            employees.Add(new Employee(105, "Test", "Dev",  "Pro005"));
            employees.Add(new Employee(106, "LMN",  "Test", "Pro001"));
            employees.Add(new Employee(107, "Test", "Dev",  "Pro003"));
            employees.Add(new Employee(108, "QWE",  "Dev",  "Pro003"));
            employees.Add(new Employee(109, "ASD",  "Test", "Pro003"));

            Console.WriteLine("Where: To find all Testers");
            foreach (Employee emp in employees.Where(e => e.DepartmentName == "Test"))
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("Where: To find ID < 106");
            foreach (Employee emp in employees.Where(e => e.ID < 106))
            {
                Console.WriteLine(emp);
            }                       

            foreach (var item in employees.Select(e => { return new { Name = e.Name, Location = (e.DepartmentName =="Dev") ? "Pune" : "Mumbai" }; }))
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Location: " + item.Location);
            };

            Console.WriteLine("\nAny Employee from Pro007? {0}", employees.Any(emp => emp.ProjectName == "Pro007"));

            var groups = employees.GroupBy(emp => emp.ProjectName).Select(e => e.ToList()).ToList();
            foreach (var grp in groups)
            {
                Console.WriteLine("Project Name: {0}", grp[0].ProjectName);
                foreach (var item in grp)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine(employees.Find(e => e.Name == "Rut"));

            Console.Read();
        }
    }


}
