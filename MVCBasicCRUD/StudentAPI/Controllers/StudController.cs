using MVCBasicCRUD.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace StudentAPI.Controllers
{
    public class StudController : ApiController
    {
        public JsonResult<List<Student>> Get()
        {
            return Json(StudentContext.Students());
        }

        public JsonResult<Student> Get(int id)
        {
            return Json(StudentContext.StudentByRollNo(id));
        }

        public JsonResult<Student> Post(Student student)
        {
            student.RollNo = StudentContext.InsertStudent(student);
            return Json(student);
        }

        public JsonResult<Student> Delete(Student student)
        {
            StudentContext.DeleteStudent(student.RollNo);
            return Json(student);
        }

        public JsonResult<Student> Put([FromBody] Student student)
        {
            StudentContext.UpdateStudent(student);
            return Json(student);
        }
        
    }
}