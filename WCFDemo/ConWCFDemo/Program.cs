using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConWCFDemo.EmployeeServiceReference;

namespace ConWCFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp;
            Department dept;

            var client = new EmployeeServiceClient();

            client.Open();
            var companyName = client.GetEmployeeDetails("Admin", 101, 1, out dept, out emp);
            client.Close();

            Console.ReadLine();
        }
    }
}
