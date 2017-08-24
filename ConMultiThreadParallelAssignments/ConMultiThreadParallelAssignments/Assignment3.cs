using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConMultiThreadParallelAssignments
{
    class Assignment3
    {      
        static int num1 = 0, num2 = 0, result = 0;

        public static void Main(string[] args)
        {
            Assignment3 _object = new Assignment3();
            new Thread(_object.Divide).Start();
            _object.Divide();
        }

        public void Divide()
        {            
            Random _random = new Random();
            for(long i = 0; i < 100000; i++)
            {
                lock (this)
                {
                    num1 = _random.Next(1, 1000);
                    num2 = _random.Next(1, 1000);

                    result = num1 / num2;

                    num1 = 0;
                    num2 = 0;
                }
            }
        }
    }
}
