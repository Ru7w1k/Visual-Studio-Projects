using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConMultiThreadParallelAssignments
{
    class Assignment5
    {

        static Semaphore _semaphone = null;

        public static void Main(string[] args)
        {
            try
            {
                _semaphone = Semaphore.OpenExisting("semaphore");
            }
            catch (Exception ex)
            {
                _semaphone = new Semaphore(3, 3, "semaphore");
            }

            Console.WriteLine("Acquiring..");
            _semaphone.WaitOne();

            Console.WriteLine("Acquired!");
            Console.ReadLine();
            _semaphone.Release();
        }
    }
}
