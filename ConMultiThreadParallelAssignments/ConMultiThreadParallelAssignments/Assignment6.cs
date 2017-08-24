using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConMultiThreadParallelAssignments
{
    class Assignment6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adding Func1 to thread pool");
            ThreadPool.QueueUserWorkItem(new WaitCallback(Func1));
            Console.WriteLine("Adding Func2 to thread pool");
            ThreadPool.QueueUserWorkItem(new WaitCallback(Func2));


            Console.ReadLine();
        }


        static void Func1(object obj)
        {
            Console.WriteLine("Thread 1 Start..");
            string x = "";
            for (int i = 0; i < 100000; i++)
            {
                x += ".";
            }
            Console.WriteLine("Thread 1 finished!");
        }

        static void Func2(object obj)
        {
            Console.WriteLine("Thread 1 Start..");
            string x = "";
            for (int i = 0; i < 100000; i++)
            {
                x += ".";
            }
            Console.WriteLine("Thread 2 finished!");
        }
    }
}
