using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                    new Employee{Name="A", Age=25, DateOfJoining=DateTime.Now.AddYears(-3), Designation="SA", Email="ab@xoriant.com", Phone="34343334", Salary=25000.00f},
                    new Employee{Name="AB", Age=29, DateOfJoining=DateTime.Now.AddYears(-2), Designation="SSA", Email="ga@xoriant.com", Phone="34321454", Salary=31000.00f},
                    new Employee{Name="DA", Age=22, DateOfJoining=DateTime.Now.AddYears(-1), Designation="SE", Email="an@xoriant.com", Phone="54545454", Salary=66000.00f},
                    new Employee{Name="AF", Age=21, DateOfJoining=DateTime.Now.AddYears(-6), Designation="SE", Email="as@xoriant.com", Phone="8786454", Salary=33000.00f},
                    new Employee{Name="GA", Age=29, DateOfJoining=DateTime.Now.AddYears(-4), Designation="SSE", Email="aj@xoriant.com", Phone="43345454", Salary=75000.00f},
                    new Employee{Name="AH", Age=32, DateOfJoining=DateTime.Now.AddYears(-7), Designation="SA", Email="da@xoriant.com", Phone="8985454", Salary=23000.00f},
                    new Employee{Name="KA", Age=33, DateOfJoining=DateTime.Now.AddYears(-4), Designation="SSA", Email="ka@xoriant.com", Phone="7845454", Salary=27000.00f},
                    new Employee{Name="AL", Age=24, DateOfJoining=DateTime.Now.AddYears(-5), Designation="SE", Email="aj@xoriant.com", Phone="6545454", Salary=28000.00f},
                    new Employee{Name="TA", Age=35, DateOfJoining=DateTime.Now.AddYears(-2), Designation="SSE", Email="la@xoriant.com", Phone="3445654", Salary=23000.00f},
                    new Employee{Name="AS", Age=23, DateOfJoining=DateTime.Now.AddYears(-1), Designation="SE", Email="ra@xoriant.com", Phone="5555554", Salary=44000.00f},
                    new Employee{Name="HA", Age=27, DateOfJoining=DateTime.Now.AddYears(-6), Designation="SE", Email="aj@xoriant.com", Phone="3465654", Salary=29000.00f},
                    new Employee{Name="AJ", Age=26, DateOfJoining=DateTime.Now.AddYears(-4), Designation="SE", Email="dd@xoriant.com", Phone="3447674", Salary=32000.00f},
                    new Employee{Name="LL", Age=31, DateOfJoining=DateTime.Now.AddYears(-6), Designation="SE", Email="ss@xoriant.com", Phone="347564", Salary=55000.00f},
                    new Employee{Name="DD", Age=29, DateOfJoining=DateTime.Now.AddYears(-3), Designation="SSE", Email="ak@xoriant.com", Phone="3345654", Salary=32000.00f},
                    new Employee{Name="KK", Age=23, DateOfJoining=DateTime.Now.AddYears(-2), Designation="SA", Email="aq@xoriant.com", Phone="3445444", Salary=66000.00f},
                    new Employee{Name="SS", Age=27, DateOfJoining=DateTime.Now.AddYears(-1), Designation="SSA", Email="fa@xoriant.com", Phone="3466654", Salary=74000.00f},
                    new Employee{Name="GG", Age=24, DateOfJoining=DateTime.Now.AddYears(-3), Designation="SA", Email="ag@xoriant.com", Phone="3445444", Salary=33000.00f},
            };

            var emp =
                from e in employees
                where e.Salary > 50000.00f
                group e by e.Designation into g                
                orderby g.Key
                select new { Designation = g.Key, Employees = g };


            foreach (var item in emp)
            {
                Console.WriteLine(item.Designation);
                foreach (var e in item.Employees)
                {
                    Console.WriteLine(e.Name + " " + e.Salary);
                }
            }

            var vowels =
                from ch in "This is a test string"
                where new char[] { 'a', 'e', 'i', 'o', 'u' }.Contains(ch)
                orderby ch
                select ch;

            foreach (var ch in vowels)
            {
                Console.WriteLine(ch);
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
        public float Salary { get; set; }
        public string Designation { get; set; }

        public override string ToString()
        {
            return string.Format("\nName: :{0}\nAge: {1}\nPhone: {2}\nEmail: {3}\nDate Of Joining: {4}\nSalary: {5}\nDesignation: {6}", Name, Age, Phone, Email, DateOfJoining, Salary, Designation);
        }
    }
}
