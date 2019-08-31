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
    public class PackageEnrollmentConfiguration : IEntityTypeConfiguration<PackageEnrollment>
    {
        public void Configure(EntityTypeBuilder<PackageEnrollment> builder)
        {
            builder.ToTable("PackageEnrollments");

            builder.HasKey(ep => new { ep.EnrollmentId, ep.PackageId });
            //builder.HasKey(x => x.Id);

            //builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(32)").IsRequired();
            //builder.Property(x => x.Description).HasColumnType("varchar(256)").IsRequired();
            //builder.Property(x => x.Type).HasColumnType("int").IsRequired();

            //builder.HasMany(x => x.Sections).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId);

            builder.HasOne(ep => ep.Enrollment)
            .WithMany(e => e.Packages)
            .HasForeignKey(bc => bc.EnrollmentId);

            builder.HasOne(ep => ep.Package)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(bc => bc.PackageId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}