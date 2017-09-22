using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFFirst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudent
    {
        private List<Student> _Students = new List<Student>
        {
            new Student {Id = 1, Name = "ABC" },
            new Student {Id = 2, Name = "XYZ" },
            new Student {Id = 3, Name = "PQR" }
        };

        public List<Student> GetStudent()
        {
            return _Students;
        }

        public Student GetStudentById(int id)
        {
            return _Students.Where(s => s.Id == id).FirstOrDefault();
        }
    }
}
