using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTestApp
{
    public class Celcius
    {
        public float Degrees { get; set; }

        public Celcius(float degrees)
        {
            Degrees = degrees;
        }

        public static explicit operator Fahrenheit(Celcius c)
        {
            return new Fahrenheit((9.0f / 5.0f) * c.Degrees + 32);
        }                        
    }

    public class Fahrenheit
    {
        public float Degrees { get; set; }

        public Fahrenheit(float degrees)
        {
            Degrees = degrees;
        }

        public static explicit operator Celcius(Fahrenheit f)
        {
            return new Celcius((5.0f / 9.0f) * (f.Degrees - 32));
        }
    }

}
