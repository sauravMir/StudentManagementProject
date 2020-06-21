using System;
using System.Collections.Generic;

using FirstProject.DAL;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class GenerateController : Controller
    {

        private MySqlContext mySqlContext;

        public GenerateController(MySqlContext mySqlContext)
        {
            this.mySqlContext = mySqlContext;
        }
            // GET: /<controller>/
            public String Index()
        {
            generate();
            return "Done";
        }

        private void generate()
        {

            List<Grade> classes = new List<Grade>() {
                new Grade() { GradeId = 1, GradeName = "Jupitar" },
                  new Grade() { GradeId = 2, GradeName = "Saturn" },
            };

            List<Student> students = new List<Student>() {
                new Student() { StudentId = 1, StudentName = "Ron", Age = 12, GradeId = 1 },
                 new Student() { StudentId = 2, StudentName = "Don", Age = 10, GradeId = 2 },
                  new Student() { StudentId = 3, StudentName = "Ken", Age = 8, GradeId = 1 },
                   new Student() { StudentId = 4, StudentName = "Moon", Age = 14, GradeId = 2 },
                    new Student() { StudentId = 5, StudentName = "Mia", Age = 15, GradeId = 1 },
                     new Student() { StudentId = 6, StudentName = "Shelly", Age = 18, GradeId = 2 }
            };

            classes.ForEach(Grade => mySqlContext.Grade.Add(Grade));
            mySqlContext.SaveChanges();

            students.ForEach(student => mySqlContext.Student.Add(student));
            mySqlContext.SaveChanges();

        }
    }
}
