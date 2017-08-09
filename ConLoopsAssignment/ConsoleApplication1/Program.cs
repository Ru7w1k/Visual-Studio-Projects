using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();

            Program p = new Program();

            if(p.IsPalindrome(str))
            {
                Console.WriteLine("Palindrome!");
            }
            else
            {
                Console.WriteLine("Not Palindrome!");
            }
        }

        public bool IsPalindrome(string str)
        {
            for(int i = 0, j = str.Length - 1 ; i <= j; i++, j--)
            {
                if(str[i] != str[j])
                {
                    return false;
                }
            }
            return true;            
        }
    }
}
