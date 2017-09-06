using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class StudentController : ApiController
    {
        public static List<Student> _students = new List<Student>()
        {
            new Student() { RollNo = 1, Name = "One" },
            new Student() { RollNo = 2, Name = "Two" },
            new Student() { RollNo = 3, Name = "Three" }
        };

        // GET: Student
        public IEnumerable<Student> Get()
        {
            return _students;
        }

        public object Get(int id)
        {
            IEnumerable<Student> student = _students.Where(s => s.RollNo == id);
            if (student.Count() > 0)
                return student.First();
            else
                return new { Error = "No Student Found"};
        }

        // POST: Student
        public IEnumerable<Student> Post([FromBody] Student data)
        {
            _students.Add(data);
            return _students;
        }

        public object Put(int id, [FromBody] Student data)
        {
            IEnumerable<Student> student = _students.Where(s => s.RollNo == id);
            if (student.Count() > 0)
            {
                student.First().Name = data.Name;
                return _students;
            }
            else
            {
                return new { Error = "No Student Found" };
            }            
        }

        public object Delete(int id)
        {
            IEnumerable<Student> student = _students.Where(s => s.RollNo == id);
            if (student.Count() > 0)
            {
                _students.Remove(student.First());
                return _students;
            }
            else
            {
                return new {Error = "No Student Found"};
            }
        }


    }
}