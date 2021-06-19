using MasterMvc.Models;
using MasterMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterMvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudents()
        {
            var student = new Student() { Id = 1, Name = "Amardeep", Address = "Patna" };
            var subject = new List<Subjects>()
            {
                new Subjects(){Id=1,Name="Computer Programming"},
                new Subjects(){Id=2,Name="Database Analysis"},
                new Subjects(){Id=3,Name="Fundamental of Algorithm"}
            };

            var viewModel = new StudentViewModel()
            {
                student=student,
                Subjects=subject
            };

            return View(viewModel);
        }

        public ActionResult SingleStudent()
        {
            return View();
        }

        public ActionResult EditStudent(int id)
        {
            return Content("Student Id" + id);
        }
    }
}