using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConTestApp
{
    //public class IsAsTest
    //{
    //    public static void Test(object obj)
    //    {
    //        if(obj is )
    //        {

    //        }
    //    }
    //}
    public class BaseClass
    {
        public string BaseProp { get; set; }
    }

    public class DerivedClass : BaseClass
    {
        public string DerivedProp { get; set; }
    }


    class Test1
    {
        public string MyProperty { get; set; }
        public Test1()
        {
            MyProperty = "test1";
        }

        public string Print()
        {
            return "This is Test1 Class";
        }
        
    }

    class Test2
    {
        public string MyProperty { get; set; }
        public Test2()
        {
            MyProperty = "test2";            
        }

        public string Print()
        {
            return "This is Test2 Class";
        }
    }
    
    class Program
    {       

        static void Main(string[] args)
        {
            int a = int.MaxValue;
            int c = a * a;

            //Test1 test1 = new Test1();
            //string str = "TSTSETSETS";

            //Console.WriteLine("Size of Int    : " + sizeof(int));
            //Console.WriteLine("Size of Double : " + sizeof(double));
            //Console.WriteLine("Size of Byte   : " + sizeof(byte));
            //Console.WriteLine("Size of Bool   : " + sizeof(bool));

            //Console.WriteLine("Type of Int    : " + typeof(int));
            //Console.WriteLine("Type of Double : " + typeof(double));
            //Console.WriteLine("Type of Byte   : " + typeof(byte));
            //Console.WriteLine("Type of Bool   : " + typeof(bool));
            //Console.WriteLine("Type of Test1  : " + typeof(Test1));

            //Console.WriteLine(2+3*7+3);

            //long val = 3000000000;
            //int i = unchecked((int)val);
            //Console.WriteLine("i: " + i);

            //int i1 = 20;
            //object o = i1;
            //Console.WriteLine(o);
            //i1 = 40;
            //Console.WriteLine(o);            
            //int j = (int)o;
            //Console.WriteLine(i1);

            //var x = new Test1();
            //var y = new Test1();

            //Console.WriteLine("x and y      : " + ReferenceEquals(x, y));
            //Console.WriteLine("x and x      : " + ReferenceEquals(x, x));
            //Console.WriteLine("x and null   : " + ReferenceEquals(x, null));
            //Console.WriteLine("null and null: " + ReferenceEquals(null, null));

            //Console.WriteLine("x.Equals(y): " + x.Equals(y));
            //Console.WriteLine("x == y: " + (x == y));
            //Console.WriteLine("x.Equals(x): " + x.Equals(x));

            BaseClass derivedObj = new DerivedClass();
            BaseClass baseObj = new BaseClass();

            derivedObj.BaseProp = "test";


            DerivedClass derived1 = (DerivedClass)derivedObj;
            //DerivedClass derived2 = (DerivedClass)baseObj;

            //if (a is Test1)
            //{
            //    Console.WriteLine("A is Int");
            //}
            //else
            //{
            //    Console.WriteLine("A is not Int");
            //}

            Method1();

            //Console.WriteLine(c);
            Console.Read();
            
            //checked
            //{
            //    Console.WriteLine("Inside Checked");
            //    int d = a * a;
            //    int e = unchecked(a + a);

            //    Console.WriteLine("d: " + d);
            //    Console.WriteLine("e: " + e);

            //}

            //try
            //{
            //    int b = unchecked(a * a);
            //    Console.WriteLine(b);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            Console.Read();
        }
        

        public static void Method1()
        {
            object[] objs = new object[6];
            objs[0] = new Test1();
            objs[1] = new Test2();
            objs[2] = "String";
            objs[3] = 213;
            objs[4] = null;
            objs[5] = false;

            for(int i = 0; i < objs.Length; i++)
            {
                Test2 s = objs[i] as Test2;
                Console.Write("{0}: ", i);
                if(s != null)
                {
                    Console.WriteLine("'" + s.Print() + "'");
                }
                else
                {
                    Console.WriteLine("not a string");
                }
            }
        }

        

    }
}
