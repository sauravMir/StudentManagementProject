﻿using System;
using Microsoft.AspNetCore.Identity;

namespace FirstProject.Models
{
    public class Student : IdentityUser
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
