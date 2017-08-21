using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWOLinq
{
    public delegate bool WhereDelegate(Employee emp);
    public delegate EmployeePersonal SelectDelegate(Employee emp);

    public static class Employee3Extensions
    {
        public static IEnumerable<EmployeePersonal> FilterEmployees(List<Employee> employees)
        {
            return Select(Where(employees, new WhereDelegate(WhereClause)), new SelectDelegate(SelectClause));
        }

        private static IEnumerable<Employee> Where(IEnumerable<Employee> source, WhereDelegate whereClause)
        {
            foreach (Employee item in source)
            {
                if (whereClause(item))
                {
                    yield return item;
                }
            }
        }

        private static IEnumerable<EmployeePersonal> Select(IEnumerable<Employee> source, SelectDelegate selectClause)
        {
            List<EmployeePersonal> destination = new List<EmployeePersonal>();
            foreach (Employee item in source)
            {
                destination.Add(selectClause(item));
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
