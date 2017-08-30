#define TEST

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

    class HelpAttribute : Attribute
    {
        public string HelpText { get; set; }

    }

    [Help(HelpText = "This is a class")]
    class Customer
    {
        private string _CustomerCode;

        [Help(HelpText = "This is a property")]
        public string CustomerCode
        {
            get { return _CustomerCode; }
            set { _CustomerCode = value; }
        }

        [Help(HelpText = "This is a method")]
        public void Add()
        {

        }
    }

    public class BaseClass
    {
        public string BaseProp { get; set; }
    }

    public class DerivedClass : BaseClass
    {
        public string DerivedProp { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    class Check : Attribute
    {
        public int MaxLength { get; set; }
    }

    class Test1
    {
        [Check(MaxLength = 10)]
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

        [Conditional("TEST")]
        public void Print()
        {
            Console.WriteLine("This is Test2 Class");
        }
    }
    
    [Test1(MyProperty = "Test")]
    class Program
    {       

        static void Main(string[] args)
        {

            Test2 t = new Test2();
            t.Print();

            Customer cust = new Customer();

            //int a = int.MaxValue;
            //int c = a * a;

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

            //BaseClass derivedObj = new DerivedClass();
            //BaseClass baseObj = new BaseClass();

            //derivedObj.BaseProp = "test";


            //DerivedClass derived1 = (DerivedClass)derivedObj;
            //DerivedClass derived2 = (DerivedClass)baseObj;

            //if (a is Test1)
            //{
            //    Console.WriteLine("A is Int");
            //}
            //else
            //{
            //    Console.WriteLine("A is not Int");
            //}

            //Method1();

            //Console.WriteLine(c);
            //Console.Read();

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

            //Celcius c = new Celcius(27);
            //Fahrenheit f = (Fahrenheit)c;
            //f = new Fahrenheit(100);
            //c = (Celcius)f;

            //Console.WriteLine("C: {0}\nF: {1}", c.Degrees, f.Degrees);

            //int[][] arr = new int[3][];
            //arr[0] = new int[10];

            //SampleStruct s1 = new SampleStruct();
            //s1.Test = "testtest";

            //s1 = new SampleStruct("THIS is a test");
            //MyLinkedList<string> strList = new MyLinkedList<string>();
            //strList.Add("This");
            //strList.Add("is");
            //strList.Add("a");
            //strList.Add("test");
            //strList.Add("of");
            //strList.Add("the");
            //strList.Add("generic");
            //strList.Add("linked");
            //strList.Add("list");

            //foreach (string str in strList.GetEnumerator())
            //{
            //    Console.WriteLine(str);
            //}

            //MyMainClass.MainTest();

            //var test = new Tuple<int, int, int, int, int, int, int, Tuple<int, int>>(10, 10, 10, 10, 10, 10, 10, new Tuple<int, int>(15,16) );

            //SampleStruct test11 = new SampleStruct("test");
            ////SampleStruct test12 = new SampleStruct("test12");
            //SampleStruct test12 = test11;

            //test11.Test = "TSETSETSET";
            
            Console.Read();
        }
         
        /// <summary>
        /// Will always return zero
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        public static int MethodTest(int test)
        {
            return 0;
        }

        //public static void Method1()
        //{
        //    object[] objs = new object[6];
        //    objs[0] = new Test1();
        //    objs[1] = new Test2();
        //    objs[2] = "String";
        //    objs[3] = 213;
        //    objs[4] = null;
        //    objs[5] = false;

        //    for(int i = 0; i < objs.Length; i++)
        //    {
        //        Test2 s = objs[i] as Test2;
        //        Console.Write("{0}: ", i);
        //        if(s != null)
        //        {
        //            Console.WriteLine("'" + s.Print() + "'");
        //        }
        //        else
        //        {
        //            Console.WriteLine("not a string");
        //        }
        //    }
        //}

        

    }

    public class MyClass
    {
        public virtual int AddNumb(int numb1, int numb2)
        {
            int result = numb1 + numb2;
            return result;
        }

    }

    public class MyMainClass
    {
        public static int MainTest()
        {
            Console.WriteLine("\nReflection.MethodInfo");
            // Create MyClass object
            MyClass myClassObj = new MyClass();
            // Get the Type information.
            Type myTypeObj = myClassObj.GetType();
            // Get Method Information.
            MethodInfo myMethodInfo = myTypeObj.GetMethod("AddNumb");
            object[] mParam = new object[] { 5, 10 };
            // Get and display the Invoke method.
            Console.Write("\nFirst method - " + myTypeObj.FullName + " returns " +
                                 myMethodInfo.Invoke(myClassObj, mParam) + "\n");
            return 0;
        }
    }
}
