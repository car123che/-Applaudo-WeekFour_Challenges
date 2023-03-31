using Microsoft.EntityFrameworkCore;
using EFUnivesityDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFUnivesityData
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // -- Varchar Sizes --
            builder.Property(p => p.Name).HasMaxLength(25);

            // -- Indexes --
            builder.HasIndex(h => h.InstructorId);

            //SEEDING DATA
            builder.HasData(
                   new Department { DepartmentId = 1, Name = "Engenierr", Budget = 90000, StartDate = DateTime.Now, InstructorId = 1 }
            );
        }

    }
}
