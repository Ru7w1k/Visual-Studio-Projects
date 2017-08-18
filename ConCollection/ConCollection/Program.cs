using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("A001", "ABC", 10000));
            employees.Add(new Employee("A002", "PQR", 20000));
            employees.Add(new Employee("A003", "XYZ", 30000));
            employees.Add(new Employee("A004", "LMN", 25000));

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
