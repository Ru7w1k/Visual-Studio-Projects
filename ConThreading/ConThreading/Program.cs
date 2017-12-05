using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread _thread = new Thread(Function1);
            _thread.Start();
            
            Console.ReadLine();
        }

        public static void Function1()
        {
            string x = "";
            for (int i = 0 ; i < 1000000 ; i++)
            {
                x = x + ".";
            }
        }

        public static int Function2()
        {
            return 100;
        }
    }
}
