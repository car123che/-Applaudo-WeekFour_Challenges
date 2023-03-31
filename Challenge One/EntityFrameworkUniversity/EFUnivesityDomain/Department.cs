using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityDomain
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public float Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; } = null!;

        // For the One to many relationship with Course
        public virtual List<Course> Courses { get; set; }
    }
}
