using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestApp
{
    class Temp
    {
        public unsafe static void Main()
        {
            //int a = 10;
            //int b = 10;

            //int* ptr = &a;

            //Console.WriteLine("{0}", ++b + a++ + ++a);
            //Console.WriteLine("{0}", a);
            //void *ptr1 = (void*)ptr;
            Console.WriteLine(1 / 3 * 3);
            Console.WriteLine(1F / 3F * 3F);
            Console.WriteLine( 1M / 3M * 3M);

            Console.WriteLine((1  /  3) * 3);
            Console.WriteLine((1F / 3F) * 3F);
            Console.WriteLine((1M / 3M) * 3M);

            Console.WriteLine(1  / ( 3 *  3));
            Console.WriteLine(1F / (3F * 3F));
            Console.WriteLine(1M / (3M * 3M));

            Console.ReadLine();
        }
    }
}
