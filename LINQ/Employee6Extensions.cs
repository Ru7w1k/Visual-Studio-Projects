using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWOLinq
{
    public class Employee6Extensions
    {
        public static IEnumerable<EmployeePersonal> FilterEmployees(List<Employee> employees)
        {
            return Select(Where(employees, 
                delegate(Employee emp)
                {
                    return emp.Age > 25;
                }), 
                delegate(Employee item)
                {
                    return new EmployeePersonal() { Age = item.Age, Email = item.Email, Name = item.Name, Phone = item.Phone };
                });
        }

        private static IEnumerable<Employee> Where(IEnumerable<Employee> source, Func<Employee, bool> whereClause)
        {
            foreach (Employee item in source)
            {
                if (whereClause(item))
                {
                    yield return item;
                }
            }
        }

        private static IEnumerable<EmployeePersonal> Select(IEnumerable<Employee> source, Func<Employee, EmployeePersonal> selectClause)
        {
            List<EmployeePersonal> destination = new List<EmployeePersonal>();
            foreach (Employee item in source)
            {
                destination.Add(selectClause(item));
            }
            return destination;
        }
    }
}
