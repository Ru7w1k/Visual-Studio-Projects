using MVCBasicCRUD.Models;
using System.Collections.Generic;
using System.Web.Http;
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

        public JsonResult<List<Student>> Get(string text)
        {
            return Json(StudentContext.Search(text));
        }

        public int Post(Student student)
        {
            return StudentContext.InsertStudent(student);
        }

        public bool Delete(int id)
        {
            return StudentContext.DeleteStudent(id);
        }

        public bool Put(int id,[FromBody] Student student)
        {
            student.RollNo = id;
            return StudentContext.UpdateStudent(student);
        }

    }
}
