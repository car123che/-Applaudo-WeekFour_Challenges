using System;
using System.Collections.Generic;

namespace EFUnivesityDataTwo
{
    public partial class Instructor
    {
        public Instructor()
        {
            Departments = new HashSet<Department>();
        }

        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstMidName { get; set; } = null!;
        public DateTime HireDate { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
