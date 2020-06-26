using System;
using System.Collections.Generic;

namespace FirstProject.Models
{
    public class StudentCreateVM
    {
        public Student Student { get; set; }
        public StudentDetails StudentDetails { get; set; }
        //public int GradeId { get; set; }
        public List<Grade> Grades { set; get; }
    }
}
