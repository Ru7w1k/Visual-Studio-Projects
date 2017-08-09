using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment2
    {
        public void PrintRectangle()
        {
            int num;
            Console.WriteLine("Enter A number");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("{0}{0}{0}", num);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("{0}{1}{0}", num, new string(' ', num.ToString().Length));
                }
                Console.WriteLine("{0}{0}{0}", num);
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }
        }
    }
}
