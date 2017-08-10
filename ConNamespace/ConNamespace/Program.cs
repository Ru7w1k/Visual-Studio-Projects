using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtherNamespace;
using inNS = OtherNamespace.InnerNamespace;
using GlobalVar;

class Program
{
    public static float Main(string[] args)
    {
        System.Console.WriteLine("Command Line Arguments size {0}", args.Length);

        for(int i = 0; i < args.Length; i++)
        {
            System.Console.WriteLine("args[i] : {0}", args[i]);
        }

        return 1.0f;
    }
}



namespace ConNamespace
{
    /// <summary>
    ///  XML type comment
    /// </summary>


    class Program
    {
        static void Main(int[] args)
        {
            System.Console.WriteLine("Test int main");
        }

        void Test()
        {

        }


        public static void Main(string[] args)
        {
            OtherClass oc = new OtherClass();

            inNS.InnerNamespaceClass inc = new inNS.InnerNamespaceClass();
            System.Console.WriteLine("Other Class from Other Namespace");

            //global::Program.Main();
            
        }
    }
}


namespace OtherNamespace
{
    public class OtherClass
    {
        public void Print()
        { 
            System.Console.WriteLine("Other Class from Other Namespace");
        }
    }

    namespace InnerNamespace
    {
        public class InnerNamespaceClass
        {
            public void Test()
            {
                GlobalVar.Console.WriteLine();
            }
        }
    }
}

namespace GlobalVar
{
    public class Console
    {
        public static void WriteLine()
        {
            System.Console.WriteLine("Test Print");
        }

    }
}