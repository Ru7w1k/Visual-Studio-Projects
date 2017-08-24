using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConMultiThreadParallelAssignments
{
    class Assignment7
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(Func1);
            Task task2 = new Task(Func2);

            Console.WriteLine("Stating Task1");
            task1.Start();
            Console.WriteLine("Stating Task2");
            task2.Start();

            Console.Read();
        }

        static void Func1()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x += ".";
            }
            Console.WriteLine("Thread 1 finished!");
        }

        static void Func2()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x += ".";
            }
            Console.WriteLine("Thread 2 finished!");
        }
    }
}
