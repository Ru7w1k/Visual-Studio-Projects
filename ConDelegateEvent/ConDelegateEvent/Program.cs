using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDelegateEvent
{
    public delegate void CalculateSimpleInterest(double principle, double year, double rate);

    class Program
    {
        static void Main(string[] args)
        {
            Interest interest = new Interest();

            // delegate by Instance Method
            CalculateSimpleInterest InterestDelegate = new CalculateSimpleInterest(interest.GetTotalInterest);
            InterestDelegate += interest.GetInterestRatePerYear;

            // delegate by Anonymous Function
            //CalculateSimpleInterest InterestDelegate = delegate (double principle, double year, double rate)
            //{
            //    Console.WriteLine((principle * rate * year) / 100);
            //};

            // delegate by Lambda Expression
            //CalculateSimpleInterest InterestDelegate = (p, y, r) =>
            //{
            //    Console.WriteLine((p * y * r) / 100);
            //};

            // delegate using Func
            //Func<double, double, double, void> CalculateInterest = interest.GetTotalInterest;


            //Action<double, double, double> CalculateInterest = (p, r, t) =>
            //{
            //    Console.WriteLine(p * r * t / 100);
            //};

            //CalculateInterest(10000, 2, 5);
            InterestDelegate(10000, 2, 5);
            Console.Read();
        }
    }

    public class Interest
    {
        public void GetTotalInterest(double principle, double year, double rate)
        {
            Console.WriteLine((principle * rate * year) / 100);
        }

        public void GetInterestRatePerYear(double principle, double year, double rate)
        {
            double interest = (principle * rate * year) / 100;
            Console.WriteLine((interest / (year * principle)));
        }
    }

}
