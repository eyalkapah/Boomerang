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
    public class SiteConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.ToTable("Sites");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasColumnName("Name").HasColumnType("varchar(16)").IsRequired();
            builder.Property(x => x.Rank).HasColumnType("int").IsRequired();
            builder.Property(x => x.TotalLogins).HasColumnType("int").IsRequired();
            builder.Property(x => x.MaxDownloadLogins).HasColumnType("int").IsRequired();
            builder.Property(x => x.MaxUploadLogins).HasColumnType("int").IsRequired();
        }
    }
}