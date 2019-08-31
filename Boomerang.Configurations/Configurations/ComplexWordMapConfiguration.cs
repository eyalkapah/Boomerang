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
    public class ComplexWordMapConfiguration : IEntityTypeConfiguration<ComplexWordMap>
    {
        public void Configure(EntityTypeBuilder<ComplexWordMap> builder)
        {
            builder.ToTable("ComplexWordMap");

            builder.HasKey(cwm => new { cwm.WordId, cwm.ComplexWordId });

            builder.HasOne(cwm => cwm.Word)
            .WithMany(e => e.ComplexWords)
            .HasForeignKey(bc => bc.WordId);

            builder.HasOne(cwm => cwm.ComplexWord)
                .WithMany(c => c.Words)
                .HasForeignKey(bc => bc.ComplexWordId);
        }
    }
}