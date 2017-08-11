using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAdvanceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //PartialClass pc = new PartialClass();
            //pc.PrintMsg();
            //pc.PrintMsg("test");
            //pc.Print();

            int i = 10;
            Console.WriteLine(i.Cube());

            int[] arr = new int[] {1,5,6,2,1,4,5,2,3,6,4,8 };
            foreach (var num in arr.Sort())
            {
                Console.WriteLine(num);
            }

            string str = "test";
            str.Where()

            Console.WriteLine("Area: {0}", Rectangle.Area(45.26, 123.15));

            IEmployee emp = new PartTimeEmp();
            IEmployee emp1 = new FullTimeEmp();
                        
            Test(emp);
            Test(emp1);

            Test t = new Test();
            

            Console.Read();
        }

        public static void Test(IEmployee emp)
        {
            emp.Display();
            emp.CalculateSalary();            
        }
    }

    public partial class PartialClass
    {
        private int data = 10;

        public void PrintMsg(string data)
        {
            Console.WriteLine("This is another method");
        }

    }

    public partial class PartialClass
    {
        public void Print()
        {
            Console.WriteLine("This is from third segment");
        }
    }

}
