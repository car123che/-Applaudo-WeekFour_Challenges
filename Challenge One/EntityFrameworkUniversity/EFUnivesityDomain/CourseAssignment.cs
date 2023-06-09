﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityDomain
{
    public class CourseAssignment
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Instructor Instructor { get; set; } = null!;
    }
}
