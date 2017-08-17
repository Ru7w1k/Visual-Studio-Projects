using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 123.654;
            double b = 984.159;
            Console.WriteLine("a: {0} b: {1}", a, b);
            Swapper<double>.Swap(ref a, ref b);
            Console.WriteLine("a: {0} b: {1}", a, b);

            Console.Read();
        }
    }
    
    public class Swapper<T> where T: struct
    {
        public static void Swap(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
    }
}
