using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConMultiThreadParallelAssignments
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            Thread _thread1 = new Thread(Func1);
            Thread _thread2 = new Thread(Func2);

            Console.WriteLine("Main Thread Started!");

            Console.WriteLine("Starting Thread 1");
            _thread1.Start();

            Console.WriteLine("Starting Thread 2");
            _thread2.Start();

            Console.WriteLine("Main Thread Terminated!");
            Console.Read();
        }

        static void Func1()
        {
            String x = "";
            for(int i = 0; i < 1000000; i++)
            {
                x += i;
            }
            Console.WriteLine("Thread 1 finished!");
        }

        static void Func2()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x += i;
            }
            Console.WriteLine("Thread 2 finished!");
        }
    }

}
