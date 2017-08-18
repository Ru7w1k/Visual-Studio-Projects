using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringBuilder sb = new MyStringBuilder();

            sb.Append("This is a test");
            Console.WriteLine(sb + " : " + sb.Length);
            sb.Append("Another");
            Console.WriteLine(sb + " : " + sb.Length);
            Console.WriteLine(sb[20]);
            sb.AppendAt(5, "APPENDED STRING");
            Console.WriteLine(sb + " : " + sb.Length);
            sb.Clear();
            
            Console.WriteLine(sb + " : " + sb.Length);
            sb.Append("Test");
            sb.Replace('T', 'x');
            Console.WriteLine(sb + " : " + sb.Length);
            
            Console.ReadLine();
        }
    }

    public class MyStringBuilder
    {        
        private List<char> _string = new List<char>();
        private int _length = 0;

        public int Length
        {
            get { return _length; }
        }

        public char this[int index]
        {
            get { return _string[index]; }
            set { _string[index] = value; }
        }

        public MyStringBuilder()
        {
            _length = 0;
        }

        public MyStringBuilder(char data)
        {
            _string.Add(data);
            _length++;            
        }

        public MyStringBuilder(string data)
        {
            _string.AddRange(data.ToArray());
            _length += data.Length;
        }

        public void Replace(char oldC, char newC)
        {
            _string[_string.FindIndex(c => c.Equals(oldC))] = newC;
        }

        public void Append(char data)
        {
            _string.Add(data);
            _length ++;
        }

        public void Append(string data)
        {
            _string.AddRange(data);
            _length += data.Length;
        }

        public void Clear()
        {
            _string.Clear();
            _length = 0;
        }

        public void AppendAt(int index, char value)
        {
            _string.Insert(index, value);
            _length ++;
        }

        public void AppendAt(int index, string value)
        {
            for(int i = 0; i< value.Length; i++)
                _string.Insert(index + i, value[i]);
            _length += value.Length;
        }

        public override string ToString()
        {
            return new string(_string.ToArray());
        }
    }
}
