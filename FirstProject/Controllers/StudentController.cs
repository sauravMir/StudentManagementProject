using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using FirstProject.DAL;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            List<Student> s = mySqlContext.Student.ToList();
            Grade g = s[4].Grade;
            return View(s);
        }

        public ActionResult Edit(int Id)
        {
         
            Student std = mySqlContext.Student.Include(x => x.Grade)
               .Include(details => details.StudentDetails).FirstOrDefault(x => x.StudentId == Id);
            List<Grade> grades = mySqlContext.Grade.ToList ();
            StudentCreateVM dynamicModel = new StudentCreateVM();
            dynamicModel.Student = std;
            dynamicModel.Grades = grades;
            //dynamicModel.StudentDetails = 
            //var anonymousObjResult = mySqlContext.Student
            //                .Where(st => st.StudentId == 1)
            //                .Select(st => new {
            //                    Id = st.StudentId,
            //                    Name = st.StudentName
            //                });

            return View(dynamicModel);
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
            StudentDetails studentDetails = new StudentDetails();
            List<Grade> grade = mySqlContext.Grade.ToList();
            StudentCreateVM dynamicModel = new StudentCreateVM();
            dynamicModel.Student = student;
            dynamicModel.Grades = grade;
            dynamicModel.StudentDetails = studentDetails;

            return View(dynamicModel);
        }
        [HttpPost]
        public ActionResult Create(Student student, StudentDetails studentDetails)
        {
            student.StudentDetails = studentDetails;
            mySqlContext.Student.Add(student);
            mySqlContext.Add(studentDetails);
            mySqlContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
