using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWOLinq
{
    public class Employee1Extensions
    {
        public static IEnumerable<EmployeePersonal> FilterEmployees(List<Employee> employees)
        {
            return Select(Where(employees));
        }

        private static IEnumerable<Employee> Where(IEnumerable<Employee> source)
        {
            foreach (Employee item in source)
            {
                if (item.Age > 25)
                {
                    yield return item;
                }
            }
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
