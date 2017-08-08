using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAbstractClass
{
    abstract class AbstractClass
    {
        public abstract void Eat();
        public void Sound()
        {
            Console.WriteLine("Animal Can Sound");         
        }
    }

    class Dog : AbstractClass
    {
        public override void Eat()
        {
            Console.WriteLine("Dog Can Eat");
        }
    }
}
