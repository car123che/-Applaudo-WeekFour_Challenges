﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityDomain
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public float Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; } 


    }
}
