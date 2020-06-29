using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FirstProject.Models
{
    public class Student
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }

        public int? StudentDetailsId { get; set; }
        public virtual StudentDetails StudentDetails { get; set; }
    }
}
