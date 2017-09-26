using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFDemo
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        EmployeeResponse GetEmployeeDetails(EmployeeRequest request);

        [OperationContract]
        EmployeeResponse GetEmployeeDetailsById(EmployeeRequest request);
    }
}
