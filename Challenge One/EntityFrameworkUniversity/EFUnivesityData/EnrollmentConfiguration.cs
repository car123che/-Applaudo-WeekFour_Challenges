using EFUnivesityDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFUnivesityData
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            // -- Indexes --
            builder.HasIndex(h => h.CourseId);
            builder.HasIndex(h => new { h.CourseId, h.StudentId });

            //SEEDING DATA
            builder.HasData(
                   new Enrollment { EnrollmentId = 1, CourseId = 1, StudentId = 1, Grade = 50 },
                   new Enrollment { EnrollmentId = 2, CourseId = 1, StudentId = 2, Grade = 80 },
                   new Enrollment { EnrollmentId = 3, CourseId = 2, StudentId = 2, Grade = 70 }
            );
        }
    }
}
