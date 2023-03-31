using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityDomain
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; } = null!;
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        // For the One to many relationships
        public virtual List<Enrollment> Enrollments { get; set; }
    }
}
