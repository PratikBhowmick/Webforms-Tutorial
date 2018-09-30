using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentModel student = new StudentModel()
            {
                id = 1,
                name = "Besant",
                marks = 75,
                city = "Bengaluru"
            };           


            return View(student);
        }

        public ActionResult StudentList()
        {
            List<StudentModel> listOfStudent = new List<StudentModel>();

            StudentModel student1 = new StudentModel()
            {
                id = 1,
                name = "Raj",
                marks = 75,
                city = "Bengaluru"
            };

            StudentModel student2 = new StudentModel()
            {
                id = 2,
                name = "Rishav",
                marks = 48,
                city = "Mumbai"
            };

            StudentModel student3 = new StudentModel()
            {
                id = 3,
                name = "Aman",
                marks = 76,
                city = "Kolkata"
            };

            listOfStudent.Add(student1);
            listOfStudent.Add(student2);
            listOfStudent.Add(student3);

            return View(listOfStudent);
        }

        [HttpGet]
        public ActionResult StudentCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentCreate(StudentModel model)
        {
            if(ModelState.IsValid)
            {

            }
            return View("StudentCreate");
        }
    }
}