using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConAsync
{
    public class Test
    {
        public async Task<int> GetNumberAsync()
        {
            return await Task.Run(() => FindNumber());
        }

        public int FindNumber()
        {
            Thread.Sleep(3000);
            return 100;
        }

        public async void DemoMethod()
        {

            Console.WriteLine("Before GetNumberAsyn Called");
            int x = await GetNumberAsync();

            Console.WriteLine("GetNumberAsyn Called");
            Console.WriteLine("Value of x " + x);
            Console.WriteLine("Statement after result");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.DemoMethod();
            Console.WriteLine("After DemoMethod called..");


            Console.ReadLine();
        }
    }
}
