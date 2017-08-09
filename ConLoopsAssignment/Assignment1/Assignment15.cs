using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment15
    {
        public void DisplayCube()
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

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine("Number is : {0} and Cube of the {0} is : {1}", i, (i*i*i));
            }
        }
    }
}
