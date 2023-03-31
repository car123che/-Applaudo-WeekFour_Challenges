using System;
using System.Collections.Generic;

namespace EFUnivesityDataTwo
{
    public partial class VStudentCourse
    {
        public int StudentId { get; set; }
        public string StudentNames { get; set; } = null!;
        public string CourseTitle { get; set; } = null!;
        public int CourseCredits { get; set; }
        public string InstructorNames { get; set; } = null!;
        public decimal CourseGrade { get; set; }
    }
}
