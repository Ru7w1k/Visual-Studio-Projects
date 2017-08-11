using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConSwap
{
    class Program
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Two Numbers: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();
            //p.Swap(ref num1, ref num2);
            //Console.WriteLine(num1 + " " + num2);

            //Console.WriteLine("Enter Number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //p.PrintTable(num);

            //Console.WriteLine("Enter a string: ");
            //string str = Console.ReadLine();
            //str = p.RemoveVowels(str);
            //Console.WriteLine(str);

            //string stTes = "TESt";
            //stTes = stTes.Remove(0, 1);
            //Console.WriteLine("string " + stTes);

            Console.Read();
        }

        public void Swap(ref int num1, ref int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;            
        }

        public void PrintTable(int num)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num*i);
            }
        }

        public string RemoveVowels(string str)
        {
            StringBuilder strRes = new StringBuilder();

            //foreach (char ch in str.Where(a => !vowels.Contains(a)))
            //{
            //    Console.Write(ch);
            //}

            Console.WriteLine();

            for(int i = 0; i < str.Length; i++)
            {
                if(!vowels.Contains(str[i]))
                {
                    strRes.Append(str[i]);
                    //Console.Write(str[i]);
                }
            }

            
            return strRes.ToString();
        }

    }
}
