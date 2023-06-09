﻿using System;
using System.Collections.Generic;

namespace EFUnivesityDataTwo
{
    public partial class CourseAssignment
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Instructor Instructor { get; set; } = null!;
    }
}
