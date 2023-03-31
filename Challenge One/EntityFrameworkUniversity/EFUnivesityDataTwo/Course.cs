using System;
using System.Collections.Generic;

namespace EFUnivesityDataTwo
{
    public partial class Course
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; } = null!;
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
