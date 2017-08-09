using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment1
    {
        public void PrintPattern()
        {
            int number;
            Console.WriteLine("Enter A number");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for(int i = 0; i < 2; i++)
                {
                    for(int j = 0; j < 4; j++)
                        Console.Write("{0} ", number);
                    Console.Write("\n");
                    for (int j = 0; j < 4; j++)
                        Console.Write("{0}", number);
                    Console.Write("\n");
                }

                //Console.WriteLine("{0} {0} {0} {0}\n{0}{0}{0}{0}", number);
                //Console.WriteLine("{0} {0} {0} {0}\n{0}{0}{0}{0}", number);

            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }
        }

    }
}
