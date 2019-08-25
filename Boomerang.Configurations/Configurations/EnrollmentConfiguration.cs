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
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.ToTable("Enrollments");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Affils).IsRequired().HasColumnType("varchar(512)");
            builder.Property(x => x.Status).HasColumnType("int").IsRequired();

            builder.HasOne(c => c.Site).WithMany(x => x.Enrollments).HasForeignKey(x => x.SiteId);
            builder.HasOne(c => c.Section).WithMany(x => x.Enrollments).HasForeignKey(x => x.SectionId);
        }
    }
}