using Boomerang.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Configurations.Configurations
{
    public class EnrollmentStatusConfiguration : IEntityTypeConfiguration<EnrollmentStatus>
    {
        public void Configure(EntityTypeBuilder<EnrollmentStatus> builder)
        {
            builder.ToTable("EnrollmentStatus");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(32)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("varchar(256)");
        }
    }
}