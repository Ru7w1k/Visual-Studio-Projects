using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment10
    {
        public void DisplayMsg()
        {
            int temp = 0;
            Console.WriteLine("Enter Temperature: ");
            if(int.TryParse(Console.ReadLine(), out temp))
            {
                if(temp < 0)
                {
                    Console.WriteLine("Freezing Weather");
                }
                else if(temp < 10)
                {
                    Console.WriteLine("Very Cold Weather");
                }
                else if(temp < 20)
                {
                    Console.WriteLine("Cold Weather");
                }
                else if(temp < 30)
                {
                    Console.WriteLine("Normal in Temp");
                }
                else if(temp < 40)
                {
                    Console.WriteLine("Its Hot");
                }
                else
                {
                    Console.WriteLine("Its very Hot");
                }
            }
        }
    }
}
