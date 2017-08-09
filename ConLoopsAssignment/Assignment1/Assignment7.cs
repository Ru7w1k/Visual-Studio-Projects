using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment7
    {
        public void ReverseWordOrder()
        {
            Console.WriteLine("Enter A statement: ");
            List<string> statement = new List<string>(Console.ReadLine().Split(' '));
            statement.Reverse();
            foreach (var word in statement)
            {
                Console.Write(word + " ");
            }                
        }
    }
}
