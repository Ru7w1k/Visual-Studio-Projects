using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignments
{
    public static class StringExtension
    {
        public static string ToWordUpperCase(this string str)
        {
            string[] words = str.Split(' ', '.', ',', '?');
            StringBuilder strRes = new StringBuilder();
            foreach(string word in words)
            {
                strRes.Append(word[0].ToString().ToUpper());
                strRes.Append(word.Substring(1, word.Length - 1) + " ");
            }
            return strRes.ToString();
        }
    }
}
