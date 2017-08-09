using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment11
    {
        public void IsVowel()
        {
            Console.WriteLine("Enter Character: ");
            char ch;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            if(char.TryParse(Console.ReadLine().ToString().ToLower(), out ch))
            {
                Console.WriteLine();
                if(ch < 'a' || ch > 'z')
                {
                    Console.WriteLine("Invalid Character");
                    return;
                }

                if(vowels.Contains(ch))
                {
                    Console.WriteLine("The Alphabet is Vowel");
                }
                else
                {
                    Console.WriteLine("The Alphabet is Consonant");
                }
            }
            else
            {
                Console.WriteLine("Invalid Character");
            }
        }
    }
}
