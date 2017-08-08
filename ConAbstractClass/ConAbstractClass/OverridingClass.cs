using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAbstractClass2
{
    class BaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("This is the base Class");
        }

    }

    class DerivedClass : BaseClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("This is Derived Class");
        }
    }
}
