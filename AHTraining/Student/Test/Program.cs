using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Data;
using Student.Model;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentUoW UoW = new StudentUoW();

            UoW.Students.Create(new Stud { Name = "Rutwik", Branch = "Comp", Marks = 90, Year = 4 });
            UoW.Commit();

            var temp = UoW.Students.GetAll().ToList();

            var stud = UoW.Students.GetById(1);
            stud.Marks = 50;

            UoW.Students.Update(stud);
            UoW.Commit();

            stud = UoW.Students.GetById(1);

            UoW.Students.Delete(2);
            UoW.Commit();

            temp = UoW.Students.GetAll().ToList();

            Console.ReadLine();

        }
    }
}
