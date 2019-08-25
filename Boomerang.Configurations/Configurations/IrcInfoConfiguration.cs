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
    public class IrcInfoConfiguration : IEntityTypeConfiguration<IrcInfo>
    {
        public void Configure(EntityTypeBuilder<IrcInfo> builder)
        {
            builder.ToTable("IrcInfo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Bot).IsRequired().HasColumnType("varchar(32)").IsRequired();
            builder.Property(x => x.Channel).HasColumnType("varchar(32)").IsRequired();
        }
    }
}