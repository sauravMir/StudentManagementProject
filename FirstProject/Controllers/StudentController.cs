using System;
using System.Collections.Generic;
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
            List<Student> s = mySqlContext.student.ToList<Student>();
            return View(s);
        }

        public ActionResult Edit(int Id)
        {
            Student std = mySqlContext.student.FindAsync(Id).Result;

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            mySqlContext.student.Update(student);
            mySqlContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
