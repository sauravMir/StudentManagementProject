using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FirstProject.Models
{
    public class Student
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema
            .DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int GradeId { get; set; }
        //[ForeignKey("GradeId")]
        public virtual Grade Grade { get; set; }
    }
}
