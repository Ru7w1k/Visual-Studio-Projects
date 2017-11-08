using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestApp
{
    public class Equal
    {
        public static void Main(string[] args)
        {
            Celcius c1 = new Celcius(14);
            Celcius c2 = new Celcius(14);

            if(c1.Degrees == c2.Degrees)
                Console.WriteLine("Equal!");
            else
                Console.WriteLine("Not!");


            Console.ReadLine();
        }
    }
}
