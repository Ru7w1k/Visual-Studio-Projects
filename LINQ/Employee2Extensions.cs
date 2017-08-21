using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWOLinq
{
    public static class Employee2Extensions
    {
        public static IEnumerable<EmployeePersonal> FilterEmployees(List<Employee> employees)
        {
            return Select(Where(employees));
        }

        private static IEnumerable<Employee> Where(IEnumerable<Employee> source)
        {
            foreach (Employee item in source)
            {
                if (WhereClause(item))
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
                destination.Add(SelectClause(item));
            }
            return destination;
        }

        private static bool WhereClause(Employee emp)
        {
            return emp.Age > 25;
        }

        private static EmployeePersonal SelectClause(Employee emp)
        {
            return new EmployeePersonal { Age = emp.Age, Email = emp.Email, Name = emp.Name, Phone = emp.Phone };
        }
    }
}
