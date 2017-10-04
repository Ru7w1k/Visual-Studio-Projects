using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LibWcfService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        int Add(int num1, int num2);

        [OperationContract]
        int Sub(int num1, int num2);

        [OperationContract]
        int Mul(int num1, int num2);

        [OperationContract]
        int Div(int num1, int num2);
    }
}
