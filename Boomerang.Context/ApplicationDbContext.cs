using Boomerang.Configurations.Configurations;
using Boomerang.Models.Enums;
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
        public DbSet<PreDb> PreDbs { get; set; }
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
            builder.ApplyConfiguration(new PreDbConfiguration());

            builder.Entity<PreDb>().HasData(new PreDb
            {
                Id = 1,
                Name = "SI-DB",
                Channel = "#scumm-pre",
                Bot = "SIDB",
                IsEnabled = true
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Audio",
                Type = CategoryType.Audio,
                Description = "Audio Category"
            });

            builder.Entity<Section>().HasData(new Section
            {
                Id = 1,
                Name = "Mp3",
                CategoryId = 1,
                Description = "Mp3 Section",
                Delimiter = '-',
                BubbleLevel = 0,
                RaceActivityInSeconds = 600,
                IsEnabled = true
            });

            builder.Entity<Section>().HasData(new Section
            {
                Id = 2,
                Name = "Flac",
                CategoryId = 1,
                Description = "Flac Section",
                Delimiter = '-',
                BubbleLevel = 0,
                RaceActivityInSeconds = 600,
                IsEnabled = true
            });
        }
    }
}