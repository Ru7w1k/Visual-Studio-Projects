using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ServiceBrokerListener.Domain;

namespace ServiceBrokerListener
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlDependencyEx listener = new SqlDependencyEx(
                @"Data Source=rutwik-c\sqlexpress;Initial Catalog=Student.Data.StudentContext;Integrated Security=True",
                "Student.Data.StudentContext",
                "Studs");

            listener.TableChanged += TableChangedEvent;

            listener.Start();
            Console.WriteLine("Listening..");
            Thread.Sleep(100000);            
            listener.Stop();
            Console.WriteLine("Stopped!");

            Console.ReadLine();
        }

        private static void TableChangedEvent(object sender, SqlDependencyEx.TableChangedEventArgs e)
        {
            Console.WriteLine("Table Event: {0} \nData: {1} \n", e.NotificationType, e.Data);
        }
        
    }
}
