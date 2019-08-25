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
        public DbSet<Category> Categories { get; set; }
        public DbSet<ComplexWord> ComplexWords { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<IrcInfo> IrcInfo { get; set; }
        public DbSet<PackageEnrollment> PackageEnrollments { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Word> Words { get; set; }

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
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new SectionConfiguration());
            builder.ApplyConfiguration(new WordConfiguration());
            builder.ApplyConfiguration(new ComplexWordConfiguration());
            builder.ApplyConfiguration(new PackageEnrollmentConfiguration());
            builder.ApplyConfiguration(new PackageConfiguration());
            builder.ApplyConfiguration(new EnrollmentConfiguration());
        }
    }
}