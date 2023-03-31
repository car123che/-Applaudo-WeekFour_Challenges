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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // -- Varchar Sizes --
            builder.Property(p => p.LastName).HasMaxLength(25);
            builder.Property(p => p.FirstMidName).HasMaxLength(25);


            //SEEDING DATA
            builder.HasData(
                   new Student { Id = 1, LastName = "Che", FirstMidName = "Carlos", EnrollmentDate = DateTime.Now },
                   new Student { Id = 2, LastName = "Mijangos", FirstMidName = "Agustin", EnrollmentDate = DateTime.Now }
            );
        }
    }
}
