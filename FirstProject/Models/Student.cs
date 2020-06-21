using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FirstProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int GradeId { get; set; }
        public Grade Class { get; set; }
    }
}
