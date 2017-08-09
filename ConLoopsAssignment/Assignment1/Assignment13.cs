using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment13
    {
        public void Calc()
        {
            int num1, num2, ch;
            Calculator calc;

            while (true)
            {
                Console.WriteLine("Enter The First Number");
                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid Number");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Enter The Second Number");
                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid Number");
                }
                else
                {
                    break;
                }
            }

            do
            {                
                Console.WriteLine("Here Are The Options: \n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
                Console.WriteLine("Enter Your Option:");
                if(!int.TryParse(Console.ReadLine(), out ch))
                {
                    ch = 6;
                }
                else
                {
                    calc = new Calculator();
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("The Addition of {0} and {1} is: {2}", num1, num2, calc.Add(num1, num2));
                            break;

                        case 2:
                            Console.WriteLine("The Subtraction of {0} and {1} is: {2}", num1, num2, calc.Sub(num1, num2));
                            break;

                        case 3:
                            Console.WriteLine("The Multiplication of {0} and {1} is: {2}", num1, num2, calc.Mul(num1, num2));
                            break;

                        case 4:
                            if(num2 == 0)
                            {
                                Console.WriteLine("Cannot Divide By Zero");
                                break;
                            }
                            Console.WriteLine("The Division of {0} and {1} is: {2}", num1, num2, calc.Div(num1, num2));
                            break;

                        case 5:
                            Console.WriteLine("Exit");
                            break;

                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }

            } while (ch != 5);
        }
    }

    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }

}
