using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFDemo
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeResponse GetEmployeeDetails(EmployeeRequest request)
        {
            if (request.Key == "Admin")
            {
                //Employee emp = new Employee();
                //emp.Age = 25;
                //emp.Id = 1;
                //emp.Salary = 50000;
                //emp.Name = "EmpOne";

                List<Employee> emp = new List<Employee>();
                emp.Add(new Admin()
                {
                    Id = 1,
                    Name = "admin",
                    Age = 25,
                    Salary = 50000,
                    Value = "test"
                });

                emp.Add(new Manager()
                {
                    Id = 2,
                    Name = "manager",
                    Age = 35,
                    Salary = 65000,
                    Value = "testtest"
                });
                
                Department dept = new Department();
                dept.Id = 101;
                dept.Name = "R&D";

                Logger.Log(LogType.Error, "This is error message!");

                Logger.Log(LogType.Debug, "This is debug message!");

                Logger.Log(LogType.Info, "This is information message!");

                return new EmployeeResponse() { CompanyName = "Xoriant", Emp = emp, Dept = dept};
            }
            else
            {
                return new EmployeeResponse();
            }
        }
    }
}
