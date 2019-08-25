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
    public class ReleaseConfiguration : IEntityTypeConfiguration<Release>
    {
        public void Configure(EntityTypeBuilder<Release> builder)
        {
            builder.ToTable("Releases");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnName("Name").HasColumnType("varchar(256)").IsRequired();
            builder.Property(x => x.PublishDate).HasColumnType("datetime").IsRequired();
        }
    }
}