using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAdvanceClass
{
    public partial class PartialClass
    {
        public void PrintMsg()
        {
            Console.WriteLine("Printed From Partial Class");
            Console.WriteLine("Data Value is: {0}", data);
        }

    }
}
