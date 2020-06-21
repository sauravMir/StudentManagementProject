using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using FirstProject.DAL;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace FirstProject.Controllers
{
    public class StudentController : Controller

    {
        private MySqlContext mySqlContext;

        public StudentController(MySqlContext mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }

        // GET: /<controller>/
        public ActionResult Index()
        {
            List<Student> s = mySqlContext.Student.ToList<Student>();
            return View(s);
        }

        public ActionResult Edit(int Id)
        {
            Student std = mySqlContext.Student.FindAsync(Id).Result;

            //var anonymousObjResult = mySqlContext.Student
            //                .Where(st => st.StudentId == 1)
            //                .Select(st => new {
            //                    Id = st.StudentId,
            //                    Name = st.StudentName
            //                });

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            mySqlContext.Student.Update(student);
            mySqlContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {
            Student student = new Student();
            List<Grade> grade = mySqlContext.Grade.ToList();
            dynamic dynamicModel = new ExpandoObject();
            dynamicModel.Student = student;
            dynamicModel.Grades = grade;

            return View(dynamicModel);
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            return RedirectToAction("Index");
        }
    }
}
