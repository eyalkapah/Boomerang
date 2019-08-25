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
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.ToTable("Words");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(32)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("varchar(256)").IsRequired();
            builder.Property(x => x.Classification).HasColumnType("varchar(64)").IsRequired();
            builder.Property(x => x.Pattern).HasColumnType("varchar(512)").IsRequired();
            builder.Property(x => x.IgnorePattern).HasColumnType("varchar(512)");

            builder.HasOne(c => c.ComplexWord).WithMany(w => w.Words).HasForeignKey(w => w.ComplexWordId);
            //builder.HasMany(x => x.Sections).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId);
        }
    }
}