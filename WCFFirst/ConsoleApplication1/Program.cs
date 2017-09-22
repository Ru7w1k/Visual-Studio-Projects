using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConWCFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new StudentServiceReference.StudentClient();

            try
            {
                client.Open();
                var students = client.GetStudent();
                foreach (var student in students)
                {
                    Console.WriteLine(string.Format("{0} {1}", student.Id, student.Name));
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                client.Close();
            }


            Console.ReadLine();
        }
    }
}
