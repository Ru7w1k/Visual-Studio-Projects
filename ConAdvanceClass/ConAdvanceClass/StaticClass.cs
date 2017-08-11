using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAdvanceClass
{
    public static class Rectangle
    {
        private const float _PI = 3.1415F;

        public static double Area(double num1, double num2)
        {               
            return num1 * num2;
        }

        public static int Cube(this int num)
        {
            return num * num * num;
        }

        public static int[] Sort(this int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }



    }
}
