using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LibWcfService
{
    [ServiceBehavior]
    public class Service : IService
    {
        private Guid _Guid = new Guid();

        public int Add(int num1, int num2)
        {
            Console.WriteLine("Guid : {0}, SessionId : {1}", _Guid, OperationContext.Current.SessionId);
            return num1 + num2;
        }

        public int Div(int num1, int num2)
        {
            Console.WriteLine("Guid : {0}, SessionId : {1}", _Guid, OperationContext.Current.SessionId);
            return num1 + num2;
        }

        public int Mul(int num1, int num2)
        {
            Console.WriteLine("Guid : {0}, SessionId : {1}", _Guid, OperationContext.Current.SessionId);
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            Console.WriteLine("Guid : {0}, SessionId : {1}", _Guid, OperationContext.Current.SessionId);
            return num1 + num2;
        }
    }
}