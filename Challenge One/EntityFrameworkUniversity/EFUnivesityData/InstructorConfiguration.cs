using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EFUnivesityDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace EFUnivesityData
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            // -- Varchar Sizes --
            builder.Property(p => p.LastName).HasMaxLength(25);
            builder.Property(p => p.LastName).HasMaxLength(25);


            //SEEDING DATA
            builder.HasData(
                     new Instructor { Id = 1, LastName = "Solares", FirstMidName = "Juan", HireDate = DateTime.Now }
            );
        }
    }
}
