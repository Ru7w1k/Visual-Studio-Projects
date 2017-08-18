using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEmp
{
    public class Employee : IComparable<Employee>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }


        public int CompareTo(Employee other)
        {
            return ID.CompareTo(other.ID);
        }

        public override string ToString()
        {
            return string.Format("\nID: {0}\nName: {1}\nSalary: {2}", ID, Name, Salary);
        }
    }

    class SortOnName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    class SortOnSalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee("101", "ABC", 50000));
            empList.Add(new Employee("1101", "XYZ", 60000));
            empList.Add(new Employee("1003", "PQR", 45000));
            empList.Add(new Employee("1014", "BBB", 30000));

            foreach (var emp in empList)
            {
                Console.WriteLine(emp);
            }

            empList.Sort();
            
            foreach (var emp in empList)
            {
                Console.WriteLine(emp);
            }

            empList.Sort(new SortOnSalary());

            foreach (var emp in empList)
            {
                Console.WriteLine(emp);
            }

            empList.Sort(new SortOnName());

            foreach (var emp in empList)
            {
                Console.WriteLine(emp);
            }


            Console.ReadLine();
        }
    }
}
