using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAdvanceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass pc = new PartialClass();
            pc.PrintMsg();
            pc.PrintMsg("test");
            pc.Print();
            Console.Read();
        }
    }

    public partial class PartialClass
    {
        private int data = 10;

        public void PrintMsg(string data)
        {
            Console.WriteLine("This is another method");
        }

    }

    public partial class PartialClass
    {
        public void Print()
        {
            Console.WriteLine("This is from third segment");
        }
    }

}
