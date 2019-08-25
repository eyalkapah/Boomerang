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
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.ToTable("Packages");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(128)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("varchar(256)").IsRequired();
            builder.Property(x => x.Applicability).HasColumnType("int").IsRequired();

            builder.HasOne(x => x.Word).WithMany(w => w.Packages).HasForeignKey(w => w.WordId);
            builder.HasOne(x => x.ComplexWord).WithMany(w => w.Packages).HasForeignKey(w => w.ComplexWordId);
        }
    }
}