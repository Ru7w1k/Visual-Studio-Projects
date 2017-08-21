 using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWOLinq
{
    public static class Employee0Extensions
    {
        public static IEnumerable<EmployeePersonal> FilterEmployees(List<Employee> employees)
        {
            return Select(Where(employees));
        }

        private static IEnumerable<Employee> Where(IEnumerable<Employee> source)
        {
            List<Employee> destination = new List<Employee>();
            foreach (Employee item in source)
            {
                if (item.Age > 25)
                {
                    destination.Add(item);
                }
            }
            return destination;
        }

        private static IEnumerable<EmployeePersonal> Select(IEnumerable<Employee> source)
        {
            List<EmployeePersonal> destination = new List<EmployeePersonal>();
            foreach (Employee item in source)
            {
                destination.Add(new EmployeePersonal { Age = item.Age, Email = item.Email, Name = item.Name, Phone = item.Phone });
            }
            return destination;
        }
    }
}
