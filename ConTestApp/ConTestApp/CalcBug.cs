using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestApp
{
    public class CalcBug
    {
        public static void Main(string[] args)
        {
            int T;

            T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int a, b;
                StringBuilder str = new StringBuilder();

                var line = Console.ReadLine().Split(' ');

                a = Convert.ToInt32(line[0]);
                b = Convert.ToInt32(line[1]);

                while (!(a == 0 && b == 0))
                {
                    var tmpA = (a % 10);
                    var tmpB = (b % 10);
                    var tmp = (tmpA + tmpB) % 10;
                    str.Append(tmp);
                    a /= 10;
                    b /= 10;
                }

                var ans = str.ToString().ToCharArray();
                Array.Reverse(ans);
                Console.WriteLine(ans);
            }
        }
    }
}
