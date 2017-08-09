using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment17
    {
        public void NumberPattern()
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

            for(int i = 0; i <= num; i++)
            {
                StringBuilder str = new StringBuilder();
                for(int j = 1; j < i+1; j++)
                {
                    str.Append(j);
                }
                for(int j = i-1; j > 0; j--)
                {
                    str.Append(j);
                }

                Console.WriteLine("{0}{1}", new string(' ', num - i ), str.ToString());
            }
        }
    }
}
