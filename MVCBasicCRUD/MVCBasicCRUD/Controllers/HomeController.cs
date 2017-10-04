using MVCBasicCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasicCRUD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Student> students = StudentContext.Students();
            return View(students);
        }

        public ActionResult Edit(int? id)
        {
            Student student = null;

            if (id != null)
            {
                student = StudentContext.StudentByRollNo(id.Value);
            }
            else
            {
                return RedirectToAction("Index");
            }

            return View(student);
        }

        [HttpPost]
        public ActionResult Save(Student student)
        {
            if (ModelState.IsValid)
            {
                if (StudentContext.UpdateStudent(student))
                {
                    ViewBag.Message = "Changes saved!";
                    return View("Edit", student);
                }
                else
                {
                    ViewBag.Message = "Cannot update the record";
                    return View("Edit", student);
                }
            }
            else
            {
                ViewBag.Message = "Invalid Data!";
                return View("Edit", student);
            }
        }

        public ActionResult Delete(int? id)
        {
            if(StudentContext.DeleteStudent(id.Value))
                return RedirectToAction("Index");
            else
            {
                return View("Error");
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Student student)
        {
            if (ModelState.IsValid)
            {

                if (StudentContext.InsertStudent(student))
                {
                    ViewBag.Message = "Student Record Inserted!";
                    return View("Create", student);
                }
                else
                {
                    ViewBag.Message = "Duplicate Roll Number!";
                    return View("Create", student);
                }

            }
            else
            {
                ViewBag.Message = "Check Validation Errors!";
                return View("Create", student);
            }
        }
    }
}