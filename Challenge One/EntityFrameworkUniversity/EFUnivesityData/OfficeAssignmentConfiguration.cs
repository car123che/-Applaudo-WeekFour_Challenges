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
    public class OfficeAssignmentConfiguration : IEntityTypeConfiguration<OfficeAssignment>
    {
        public void Configure(EntityTypeBuilder<OfficeAssignment> builder)
        {
            // -- Varchar Sizes --
            builder.Property(p => p.Location).HasMaxLength(25);


            // -- No Keys
            builder.HasNoKey();
        }
    }
}
