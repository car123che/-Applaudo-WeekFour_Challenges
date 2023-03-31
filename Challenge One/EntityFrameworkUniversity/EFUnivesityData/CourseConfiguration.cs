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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            // -- Varchar Sizes --
            builder.Property(p => p.Title).HasMaxLength(25);

            // -- Indexes --
            builder.HasIndex(h => h.DepartmentId);

            //SEEDING DATA
            builder.HasData(
                    new Course { CourseId = 1, Title = "Progra 1", Credits = 5, DepartmentId = 1 },
                    new Course { CourseId = 2, Title = "Progra 2", Credits = 4, DepartmentId = 1 }
            );
        }
    }
}
