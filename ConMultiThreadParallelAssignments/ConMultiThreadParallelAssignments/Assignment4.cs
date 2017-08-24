using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConMultiThreadParallelAssignments
{
    class Assignment4
    {
        public static void Main(string[] args)
        {
            using (var m = new Mutex(false, "mutOne"))
            {
                if (!m.WaitOne(5000, false))
                {
                    Console.WriteLine("An Instance Is Already Running!");                    
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("App running..");
                Console.ReadLine();
                m.ReleaseMutex();
            }
        }
    }
}
