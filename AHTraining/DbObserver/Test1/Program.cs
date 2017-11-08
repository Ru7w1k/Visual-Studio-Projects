using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBrokerListener;
using System.Threading;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer observer = Observer.GetInstance(@"Data Source=rutwik-c\sqlexpress;Initial Catalog=Student.Data.StudentContext;Integrated Security=True",
                "Student.Data.StudentContext",
                "Studs");

            Console.WriteLine(observer.GetHashCode());

            Observer observer2 = Observer.GetInstance(@"Data Source=rutwik-c\sqlexpress;Initial Catalog=Student.Data.StudentContext;Integrated Security=True",
                "Student.Data.StudentContext",
                "Studs");

            Console.WriteLine(observer2.GetHashCode());

            observer.AddListener(MyMethod);
            observer2.AddListener(MyMethod2);
            Console.WriteLine("Listening..");
            Thread.Sleep(100000);
            Console.WriteLine("Stopped..");
        }

        private static void MyMethod(object sender, ServiceBrokerListener.Domain.SqlDependencyEx.TableChangedEventArgs e)
        {
            Console.WriteLine("1. Table Event: {0} \nData: {1} \n", e.NotificationType, e.Data);
        }

        private static void MyMethod2(object sender, ServiceBrokerListener.Domain.SqlDependencyEx.TableChangedEventArgs e)
        {
            Console.WriteLine("2. Table Event: {0} \nData: {1} \n", e.NotificationType, e.Data);
        }
    }
}
