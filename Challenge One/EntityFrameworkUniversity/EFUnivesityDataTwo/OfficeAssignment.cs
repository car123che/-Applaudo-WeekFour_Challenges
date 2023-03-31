using System;
using System.Collections.Generic;

namespace EFUnivesityDataTwo
{
    public partial class OfficeAssignment
    {
        public int InstructorId { get; set; }
        public string Location { get; set; } = null!;

        public virtual Instructor Instructor { get; set; } = null!;
    }
}
