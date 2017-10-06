using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCBasicCRUD.Models;
using System.Web.Http.Results;

namespace StudentAPI.Controllers
{
    public class StudentsController : ApiController
    {
        public JsonResult<List<Student>> Get()
        {
            return Json(StudentContext.Students());
        }

        public Student Get(int id)
        {
            return StudentContext.StudentByRollNo(id);
        }

        public bool Post([FromBody]Student student)
        {
            return StudentContext.InsertStudent(student);
        }

        public bool Delete(int id)
        {
            return StudentContext.DeleteStudent(id);
        }

        public bool Put(int id, [FromBody]Student student)
        {
            student.RollNo = id;
            return StudentContext.UpdateStudent(student);
        }

    }
}
