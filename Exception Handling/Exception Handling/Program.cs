using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, opt;
                        
            Console.WriteLine("Enter 1st number: ");

            while(!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid Number!\nEnter Again");
            }

            Console.WriteLine("Enter 2nd number: ");

            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid Number!\nEnter Again");
            }

            do
            {
                Console.WriteLine("1.Add\n2.Sub\n3.Mul\n4.Div\n5.Exit");
                Console.WriteLine("Enter Option: ");

                while (!int.TryParse(Console.ReadLine(), out opt))
                {
                    Console.WriteLine("Invalid Number!\nEnter Again");
                }

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Add Result: {0}", MathLib.Math.Add(num1, num2));
                        break;

                    case 2:
                        Console.WriteLine("Sub Result: {0}", MathLib.Math.Sub(num1, num2));
                        break;

                    case 3:
                        Console.WriteLine("Mul Result: {0}", MathLib.Math.Mul(num1, num2));
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Div Result: {0}", MathLib.Math.Div(num1, num2));
                        }
                        catch (MathException e)
                        {
                            Console.WriteLine(e.Message + " " + e.MethodName);
                        }
                        break;

                    case 5:
                        break;

                    default:
                        break;
                }
            } while (opt != 5);

        }
    }
}
