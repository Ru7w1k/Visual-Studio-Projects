using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConTestApp
{
    class Test123 : Form
    {
        Button bt = new Button();
    }

    class Program
    {
        public int MyProperty { get; set; }

        public delegate string MyDelegate(string s);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From C#!");

            MyDelegate  test = new MyDelegate(Test1);
            Console.WriteLine("Test1 from delegate: " + test("Test"));

            Console.Read();
        }

        public static string Test1(string str)
        {
            return "Test1";
        }

        

    }
}
