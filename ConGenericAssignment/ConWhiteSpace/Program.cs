using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConWhiteSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Regex spaceRemove = new Regex(@"\s+");            
            Console.WriteLine(spaceRemove.Replace(str, " "));

            Console.ReadLine();
        }
    }
}
