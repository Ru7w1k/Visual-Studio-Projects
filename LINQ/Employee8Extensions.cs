using System;
using System.Collections.Generic;
using System.Text;

namespace LinqWOLinq
{
    public static class Employee8Extensions
    {
        public static IEnumerable<EmployeePersonal> FilterEmployees(List<Employee> employees)
        {
            return Select<Employee, EmployeePersonal>(Where<Employee>(employees, emp => emp.Age > 26),
                item => new EmployeePersonal() { Age = item.Age, Email = item.Email, Name = item.Name, Phone = item.Phone });
        }

        private static IEnumerable<TInput> Where<TInput>(IEnumerable<TInput> source, Func<TInput, bool> whereClause)
        {
            foreach (TInput item in source)
            {
                if (whereClause(item))
                {
                    yield return item;
                }
            }
        }

        private static IEnumerable<TOutput> Select<TInput, TOutput>(IEnumerable<TInput> source, Func<TInput, TOutput> selectClause)
        {
            List<TOutput> destination = new List<TOutput>();
            foreach (TInput item in source)
            {
                destination.Add(selectClause(item));
            }
            return destination;
        }
    }
}
