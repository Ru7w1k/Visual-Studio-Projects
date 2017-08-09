using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment16
    {
        public void PrintDiamond()
        {
            int num;
            while (true)
            {
                Console.WriteLine("Enter The Number");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid Number");
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < num/2; i++)
            {
                Console.WriteLine("{0}{1}", new string(' ', num/2 - i), new string('*', (2*i)+1));
            }
            for (int i = num/2; i >= 0; i--)
            {
                Console.WriteLine("{0}{1}", new string(' ', num/2 - i), new string('*', (2 * i) + 1));
            }
        }
    }
}
