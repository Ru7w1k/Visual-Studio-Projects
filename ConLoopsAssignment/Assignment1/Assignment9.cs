using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment9
    {
        public void GreatestNumber()
        {
            int[] nums = new int[3];
            Console.WriteLine("Enter three Numbers: ");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Number {0} : ", i);
                if(!int.TryParse(Console.ReadLine(), out nums[i]))
                {
                    Console.WriteLine("Invalid Number, Enter Again!");
                    i--;
                    continue;
                }
            }

            if(nums[0] > nums[1])
            {
                if(nums[0] > nums[2])
                {
                    Console.WriteLine("1st number is greatest {0}", nums[0]);
                }
                else
                {
                    Console.WriteLine("3nd number is greatest {0}", nums[2]);
                }
            }
            else
            {
                if (nums[1] > nums[2])
                {
                    Console.WriteLine("2st number is greatest {0}", nums[1]);
                }
                else
                {
                    Console.WriteLine("3nd number is greatest {0}", nums[2]);
                }

            }
        }
    }
}
