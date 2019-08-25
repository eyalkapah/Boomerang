using Boomerang.Configurations.Configurations;
using Boomerang.Models.DTOs;
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
        public DbSet<Release> Releases { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ReleaseConfiguration());
        }
    }
}