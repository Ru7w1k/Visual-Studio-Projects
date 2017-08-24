using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            // using Task Parallel Library
            Parallel.For(0, 1000000, x => Function1());
            Console.ReadLine();            
        }

        public static void Function1()
        {
            string x = "";
            for(int i = 0; i < 1000000; i++)
            {
                x = x + ".";
            }
        }
    }
}
