using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConProgrammingChallanges
{
    public class Bird
    {
        public void Walk()
        {
            Console.WriteLine("Bird Can Walk");
        }
    }

    public class BirdOne : Bird
    {
        public void Fly()
        {
            Console.WriteLine("Bird Can Fly");
        }
    }

    public class BirdTow : Bird
    {
        public void Sing()
        {
            Console.WriteLine("Bird Can Sing");
        }
    }
}
