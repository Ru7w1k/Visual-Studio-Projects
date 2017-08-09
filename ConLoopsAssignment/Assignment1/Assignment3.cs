using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment3
    {
        public void CelciusToFahrenheit()
        {
            int celcius;
            Console.WriteLine("Enter celcius Temperature:");
            if (int.TryParse(Console.ReadLine(), out celcius))
            {
                Console.WriteLine("Fahrenheit : {0}", (celcius * 1.8) + 32);
            }
            else
            {
                Console.WriteLine("Invalid celcius!");
            }            
        }
    }
}
