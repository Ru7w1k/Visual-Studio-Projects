using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class EmployeeBLL
    {
        private EmployeeContext _EmployeeContext;

        public EmployeeBLL()
        {
            _EmployeeContext = new EmployeeContext();
        }

        public void InsertEmployee(Employee emp)
        {
            _EmployeeContext.Employees.Add(emp);
            _EmployeeContext.SaveChanges();
        }

        public void DeleteEmployee(Employee emp)
        {
            Employee empObj = _EmployeeContext.Employees.First(e => e.EmpId == emp.EmpId);
            _EmployeeContext.Employees.Remove(empObj);
            _EmployeeContext.SaveChanges();
        }

        public void UpdateEmployee(Employee emp)
        {
            Employee empObj = _EmployeeContext.Employees.First(e => e.EmpId == emp.EmpId);

            empObj.Name = emp.Name;
            empObj.Salary = emp.Salary;
            empObj.DeptNo = emp.DeptNo;

            _EmployeeContext.SaveChanges();
        }

        public Employee[] SelectEmployee()
        {
            return _EmployeeContext.Employees.ToArray();
        }
    }
}
