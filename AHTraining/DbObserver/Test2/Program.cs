using ServiceBrokerListener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer observer = Observer.GetInstance(@"Data Source=rutwik-c\sqlexpress;Initial Catalog=Student.Data.StudentContext;Integrated Security=True",
                "Student.Data.StudentContext",
                "Studs");

            Console.WriteLine(observer.GetHashCode());

            observer.AddListener(MyMethod);
            Console.WriteLine("Listening..");
            Thread.Sleep(100000);
            Console.WriteLine("Stopped..");
        }

        private static void MyMethod(object sender, ServiceBrokerListener.Domain.SqlDependencyEx.TableChangedEventArgs e)
        {
            Console.WriteLine("2.1. Table Event: {0} \nData: {1} \n", e.NotificationType, e.Data);
        }
    }
}
