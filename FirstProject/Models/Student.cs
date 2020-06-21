﻿using System;
using Microsoft.AspNetCore.Identity;

namespace FirstProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int GradeId { get; set; }
        public Grade Class { get; set; }
    }
}
