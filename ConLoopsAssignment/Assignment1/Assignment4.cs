using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment4
    {
        public void LongestWord()
        {
            Console.WriteLine("Enter the statement: ");
            string statement = Console.ReadLine();
            
            string[] words = statement.Split(' ', '.', ',');

            string maxLenWord = "";

            foreach (var word in words)
            {
                if(word.Length >= maxLenWord.Length)
                {
                    maxLenWord = word;
                }
            }

            Console.WriteLine("The word with max letters is : {0} with {1} characters", maxLenWord, maxLenWord.Length);
        }
    }
}
