using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment14
    {
        public void DrawPattern()
        {
            int num, width;
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
            while (true)
            {
                Console.WriteLine("Enter The Width");
                if (!int.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Invalid Number");
                }
                else
                {
                    break;
                }
            }

            for(int i = 1; i <= width; i++)
            {
                Console.WriteLine(string.Join("", Enumerable.Repeat(num, width - i + 1)));
            }
        }
        
    }
}
