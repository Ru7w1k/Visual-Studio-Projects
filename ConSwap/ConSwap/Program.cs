using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();
            p.Swap(ref num1, ref num2);
            Console.WriteLine(num1 + " " + num2);

            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            p.PrintTable(num);

            Console.Read();
        }

        public void Swap(ref int num1, ref int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;            
        }

        public void PrintTable(int num)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num*i);
            }
        }

    }
}
