﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        [Display(Name ="Course Id")]
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [Display(Name ="Grade")]
        [DisplayFormat(NullDisplayText ="No grade")]
        public Grade? Grade { get; set; }

        //navigational property
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}