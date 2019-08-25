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
    public class ComplexWordConfiguration : IEntityTypeConfiguration<ComplexWord>
    {
        public void Configure(EntityTypeBuilder<ComplexWord> builder)
        {
            builder.ToTable("ComplexWords");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(32)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("varchar(256)").IsRequired();
            builder.Property(x => x.Classification).HasColumnType("varchar(64)").IsRequired();

            //builder.HasMany(x => x.Sections).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId);
        }
    }
}