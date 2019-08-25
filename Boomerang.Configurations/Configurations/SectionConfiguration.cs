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
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.ToTable("Sections");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(32)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("varchar(256)").IsRequired();
            builder.Property(x => x.Delimiter).HasColumnType("char").IsRequired();
            builder.Property(x => x.BubbleLevel).HasColumnType("int").IsRequired();
            builder.Property(x => x.IsEnabled).HasColumnType("bit").IsRequired();
            builder.Property(x => x.RaceActivityInSeconds).HasColumnType("int").IsRequired();

            //builder.HasMany(x => x.Sections).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId);
        }
    }
}