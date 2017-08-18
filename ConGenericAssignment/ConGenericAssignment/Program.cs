using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConGenericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Phone Number: ");
            string number = Console.ReadLine();

            Regex numberRegEx = new Regex(@"^\d{3}-\d{4}$");
            Match match = numberRegEx.Match(number);
            if(match.Success)
            {
                Console.WriteLine("Correct Number Format!");
            }
            else
            {
                Console.WriteLine("Invalid Number Format!");
            }

            Console.ReadLine();
        }
    }
}
