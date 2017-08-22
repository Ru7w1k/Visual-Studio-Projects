using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class MathException : Exception
    {
        public string MethodName { get; }

        public MathException(string method, string message) : base(message)
        {
            MethodName = method;
        }
    }

    public static class Math
    { 
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }


        public static int Mul(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides the first integer by second integer
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="MathException"></exception>
        public static int Div(int a, int b)
        {
            if( b == 0)
            {
                throw new MathException("Math.Div(int, int)", "Divide By Zero Exception");
            }

            return a / b;
        }
    }
}
