using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            Calculator calc = new Calculator();
            Console.WriteLine("Enter No of arguments\n1.2 \n2.3 \n3.4");
            int nos = int.Parse(Console.ReadLine());

            for(int i = 0; i <= nos; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            switch(nos)
            {
                case 1:
                    Console.WriteLine(calc.Add(numbers[0], numbers[1]));
                    break;

                case 2:
                    Console.WriteLine(calc.Add(numbers[0], numbers[1], numbers[2]));
                    break;

                case 3:
                    Console.WriteLine(calc.Add(numbers[0], numbers[1], numbers[2], numbers[3]));
                    break;

                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
           
        }
    }
}
