using LibWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(Service));
            Console.WriteLine("Starting the service");
            try
            {
                host.Open();
                Console.WriteLine("Service Started!");
                Console.WriteLine("Press Enter To Stop the service");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
