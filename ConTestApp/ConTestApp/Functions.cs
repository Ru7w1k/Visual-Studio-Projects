using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestApp
{
    class Functions
    {
        public static void Main(string[] args)
        {
            var res = Softmax(2,4,6,8);
            double temp = 0;
            foreach (var item in res)
            {
                temp += item;
            }

            Console.WriteLine(temp);

            Console.ReadLine();
        }

        private static IEnumerable<double> Softmax (params double[] args)
        {
            double total = 0;
            foreach (double num in args)
            {
                total += Math.Exp(num);
            }

            for(int i = 0; i < args.Length; i++)
            {
                args[i] = (Math.Exp(args[i]) / total);
            }
            return args;
        }
    }
}
