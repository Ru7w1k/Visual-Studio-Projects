using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment5
    {
        public void SumOfPrimes()
        {
            int sum = 0;
            int count = 0, i = 0;
            for(count = 0, i = 1; count < 1000; i++)
            {
                if(IsPrime(i))
                {
                    sum += i;
                    count += 1;
                }
            }
            Console.WriteLine("Sum of first 1000 prime numbers is : {0}", sum);
        }

        public bool IsPrime(int num)
        {
            if(num < 2)
            {
                return false;
            }

            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
