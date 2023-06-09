﻿using System;
using System.Collections.Generic;

namespace EFUnivesityDataTwo
{
    public partial class Department
    {
        public Department()
        {
            Courses = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; }
    }
}
