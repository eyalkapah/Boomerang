using Boomerang.Configurations.Configurations;
using Boomerang.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<IrcInfo> IrcInfo { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Site> Sites { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ReleaseConfiguration());
            builder.ApplyConfiguration(new SiteConfiguration());
            builder.ApplyConfiguration(new IrcInfoConfiguration());
        }
    }
}