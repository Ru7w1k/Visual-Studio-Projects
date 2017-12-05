using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestApp
{
    public class PrivateMembers
    {
        private string Test = "test";

        public void PrintTest()
        {
            Console.WriteLine(Test);
        }

        public void ChangeTest(PrivateMembers otherInstance)
        {
            // can access private members of same type!
            otherInstance.Test = "changed!";
        }

        public static void Main(string[] args)
        {
            PrivateMembers p1 = new PrivateMembers();
            PrivateMembers p2 = new PrivateMembers();

            p1.PrintTest();
            p2.PrintTest();

            p2.ChangeTest(p1);

            p1.PrintTest();
            p2.PrintTest();

            Console.ReadLine();
        }
    }
}
