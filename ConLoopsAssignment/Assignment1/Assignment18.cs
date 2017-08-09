using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment18
    {
        public void ToBinary()
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

            StringBuilder binary = new StringBuilder();
            int tmp = num;
            while(tmp > 0)
            {
                binary.Append(tmp % 2);
                tmp /= 2;
            }

            char[] temp = binary.ToString().ToCharArray();
            Array.Reverse(temp);

            Console.WriteLine("The Binary Number of {0} is {1}", num, new string(temp));
        }
    }
}
