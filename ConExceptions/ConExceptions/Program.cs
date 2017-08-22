using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Division(100, 10);
            //Division(100, 0);
            //Division(100, 100);

            Temperature t = new Temperature();
            t.SetTemp(0);

            try
            {
                t.ShowTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static void Division(int a, int b)
        {
            int res = 0;
            try
            {
                res = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception Caught! {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Div is: {0}", res);
            }
        }

    }

    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string name) : base(name)
        {

        }
    }

    public class Temperature
    {
        int temp = 0;

        public void ShowTemp()
        {
            if(temp == 0)
            {
                throw new TempIsZeroException("Zero Temperature Found!");
            }
            else
            {
                Console.WriteLine("Temperature is: {0}", temp);
            }
        }

        public void SetTemp(int t)
        {
            temp = t;
        }
    }

}
