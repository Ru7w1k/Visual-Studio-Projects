using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAbstractClass
{
    public class Calculator
    {
        public void Sum()
        {
            Console.WriteLine("No Values Provided");
        }

        public void Sum(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }

        public void Sum(float x, float y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
    }
}
