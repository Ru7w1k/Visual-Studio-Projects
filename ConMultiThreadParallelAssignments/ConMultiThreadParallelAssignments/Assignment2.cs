using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConMultiThreadParallelAssignments
{
    class Assignment2
    {
        public static void Main(string[] args)
        {
            Thread _threadF = new Thread(Func1);
            Thread _threadB = new Thread(Func2);
            _threadB.IsBackground = true;

            Console.WriteLine("Enter number to start the thread!\n1.Foreground\n2.Background");
            int opt = int.Parse(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    // foreground thread will be continue its execution, if all other threads are terminated..
                    Console.WriteLine("Starting Foreground Thread!");
                    _threadF.Start();
                    break;

                case 2:
                    // background thread will be terminated, if all foregrund thread are finished!
                    Console.WriteLine("Starting Backgroud Thread!");
                    _threadB.Start();
                    break;
            }

            Console.WriteLine("Main Thread Terminated!");
        }

        static void Func1()
        {
            String x = "";
            for (int i = 0; i < 1000000; i++)
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
