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
    public class PreDbConfiguration : IEntityTypeConfiguration<PreDb>
    {
        public void Configure(EntityTypeBuilder<PreDb> builder)
        {
            builder.ToTable("PreDbs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(32)");
            builder.Property(x => x.Bot).IsRequired().HasColumnType("varchar(32)");
            builder.Property(x => x.Channel).IsRequired().HasColumnType("varchar(64)");
            builder.Property(x => x.IsEnabled).IsRequired().HasColumnType("bit");
        }
    }
}