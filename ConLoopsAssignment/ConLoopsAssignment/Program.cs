using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLoopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Levels: ");
            int levels;
            if (int.TryParse(Console.ReadLine(), out levels))
            {
                Program p = new Program();
                p.GeneratePattern(levels);
            }
            else
            {
                Console.WriteLine("Invalid Number!!");
            }
            Console.Read();
        }

        public void GeneratePattern(int levels)
        {
            for(int i = 0; i < levels; i++)
            {
                Console.WriteLine("{0}{1}", new string(' ', levels - i), new string('*', i+1));
            }
        }
    }
}
