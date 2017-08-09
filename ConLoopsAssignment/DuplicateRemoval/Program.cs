using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Statement: ");
            string statement = Console.ReadLine();
            List<string> duplicates = new List<string>();
            List<string> stmt = new List<string>();

            Program p = new Program();
            stmt = p.RemoveDuplicatas(statement, out duplicates);

            Console.Write("New Statement : ");
            foreach (var word in stmt)
            {
                Console.Write("{0} ", word);
            }

            Console.Write("\nDuplicate Words : ");
            foreach (var word in duplicates)
            {
                Console.Write("{0} ", word);
            }
            Console.WriteLine();
        }

        public List<string> RemoveDuplicatas(string statement, out List<string> duplicates)
        {
            duplicates = new List<string>();
            List<string> words = new List<string>(statement.Split(' '));

            for (int i = 0; i < words.Count; i++)
            {
                for(int j = i + 1 ; j < words.Count; j++)
                {
                    if(words[i] == words[j])
                    {
                        duplicates.Add(words[i]);
                        words.RemoveAt(j);                                               
                    }
                }
            }

            return words;

        }
    }
}
