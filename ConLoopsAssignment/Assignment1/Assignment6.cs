using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment6
    {
        public void SumOfDigits()
        {
            int num;
            Console.WriteLine("Enter A number");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                int sum = 0;
                while(num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                Console.WriteLine("Sum of Digits: {0}", sum);
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }
        }
    }
}
