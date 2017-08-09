using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment8
    {
        public void IsLeapYear()
        {
            int year;
            Console.WriteLine("Enter Year: ");
            if (int.TryParse(Console.ReadLine(), out year))
            {
                if(year % 4 != 0)
                {
                    Console.WriteLine("{0} is not a Leap Year", year);
                }
                else if(year % 100 != 0)
                {
                    Console.WriteLine("{0} is a Leap Year", year);
                }
                else if(year % 400 != 0)
                {
                    Console.WriteLine("{0} is not a Leap Year", year);
                }
                else
                {
                    Console.WriteLine("{0} is a Leap Year", year);
                }
            }
            else
            {
                Console.WriteLine("Invalid Year!");
            }
        }
    }
}
