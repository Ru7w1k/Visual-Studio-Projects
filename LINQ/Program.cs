using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWOLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                    new Employee{Name="A", Age=25, DateOfJoining=DateTime.Now.AddYears(-3), Designation="SA", Email="ab@cybage.com", Phone="34343334", Salary=25000.00f},
                    new Employee{Name="AB", Age=29, DateOfJoining=DateTime.Now.AddYears(-2), Designation="SSA", Email="ga@cybage.com", Phone="34321454", Salary=31000.00f},
                    new Employee{Name="DA", Age=22, DateOfJoining=DateTime.Now.AddYears(-1), Designation="SE", Email="an@cybage.com", Phone="54545454", Salary=66000.00f},
                    new Employee{Name="AF", Age=21, DateOfJoining=DateTime.Now.AddYears(-6), Designation="SE", Email="as@cybage.com", Phone="8786454", Salary=33000.00f},
                    new Employee{Name="GA", Age=29, DateOfJoining=DateTime.Now.AddYears(-4), Designation="SSE", Email="aj@cybage.com", Phone="43345454", Salary=75000.00f},
                    new Employee{Name="AH", Age=32, DateOfJoining=DateTime.Now.AddYears(-7), Designation="SA", Email="da@cybage.com", Phone="8985454", Salary=23000.00f},
                    new Employee{Name="KA", Age=33, DateOfJoining=DateTime.Now.AddYears(-4), Designation="SSA", Email="ka@cybage.com", Phone="7845454", Salary=27000.00f},
                    new Employee{Name="AL", Age=24, DateOfJoining=DateTime.Now.AddYears(-5), Designation="SE", Email="aj@cybage.com", Phone="6545454", Salary=28000.00f},
                    new Employee{Name="TA", Age=35, DateOfJoining=DateTime.Now.AddYears(-2), Designation="SSE", Email="la@cybage.com", Phone="3445654", Salary=23000.00f},
                    new Employee{Name="AS", Age=23, DateOfJoining=DateTime.Now.AddYears(-1), Designation="SE", Email="ra@cybage.com", Phone="5555554", Salary=44000.00f},
                    new Employee{Name="HA", Age=27, DateOfJoining=DateTime.Now.AddYears(-6), Designation="SE", Email="aj@cybage.com", Phone="3465654", Salary=29000.00f},
                    new Employee{Name="AJ", Age=26, DateOfJoining=DateTime.Now.AddYears(-4), Designation="SE", Email="dd@cybage.com", Phone="3447674", Salary=32000.00f},
                    new Employee{Name="LL", Age=31, DateOfJoining=DateTime.Now.AddYears(-6), Designation="SE", Email="ss@cybage.com", Phone="347564", Salary=55000.00f},
                    new Employee{Name="DD", Age=29, DateOfJoining=DateTime.Now.AddYears(-3), Designation="SSE", Email="ak@cybage.com", Phone="3345654", Salary=32000.00f},
                    new Employee{Name="KK", Age=23, DateOfJoining=DateTime.Now.AddYears(-2), Designation="SA", Email="aq@cybage.com", Phone="3445444", Salary=66000.00f},
                    new Employee{Name="SS", Age=27, DateOfJoining=DateTime.Now.AddYears(-1), Designation="SSA", Email="fa@cybage.com", Phone="3466654", Salary=74000.00f},
                    new Employee{Name="GG", Age=24, DateOfJoining=DateTime.Now.AddYears(-3), Designation="SA", Email="ag@cybage.com", Phone="3445444", Salary=33000.00f},
            };

            IEnumerable<EmployeePersonal> filterEmployees = Employee9Extensions.FilterEmployees(employees);
            foreach (EmployeePersonal employee in filterEmployees)
            {
                Console.WriteLine("Employee Name: {0}, Phone Number: {1}, Email Address: {2}, Age: {3}", employee.Name, employee.Phone, employee.Email, employee.Age);
            }
            Console.Read();
        }
    }
}
