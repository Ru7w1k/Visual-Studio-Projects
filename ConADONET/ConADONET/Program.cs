using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();
                student.GetData();
                student.Update();
                student.GetData();
                //student.GetDataSet();
                //student.SaveData();
                //student.GetData1();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            Console.ReadLine();
        }
    }
}
