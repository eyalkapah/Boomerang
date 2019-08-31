using Boomerang.Configurations.Configurations;
using Boomerang.Context.Extensions;
using Boomerang.Models.Enums;
using Boomerang.Models.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<ComplexWordMap> ComplexWordMap { get; set; }
        public DbSet<ComplexWord> ComplexWords { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public IHostingEnvironment Hosting { get; }
        public DbSet<IrcInfo> IrcInfo { get; set; }
        public DbSet<PackageEnrollment> PackageEnrollments { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PreDb> PreDbs { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }

        public ApplicationDbContext(DbContextOptions options, IHostingEnvironment hosting) : base(options)
        {
            Hosting = hosting;
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ReleaseConfiguration());
            builder.ApplyConfiguration(new SiteConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new SectionConfiguration());
            builder.ApplyConfiguration(new WordConfiguration());
            builder.ApplyConfiguration(new ComplexWordConfiguration());
            builder.ApplyConfiguration(new PackageEnrollmentConfiguration());
            builder.ApplyConfiguration(new PackageConfiguration());
            builder.ApplyConfiguration(new EnrollmentConfiguration());
            builder.ApplyConfiguration(new PreDbConfiguration());
            builder.ApplyConfiguration(new ComplexWordMapConfiguration());
            builder.ApplyConfiguration(new CategoryTypeConfiguration());
            builder.ApplyConfiguration(new EnrollmentStatusConfiguration());

            builder.Seed<CategoryType>(Hosting.ContentRootPath, "categoryType.json");
            builder.Seed<EnrollmentStatus>(Hosting.ContentRootPath, "enrollmentStatus.json");
            builder.Seed<Category>(Hosting.ContentRootPath, "categories.json");
            builder.Seed<Word>(Hosting.ContentRootPath, "words.json");
            builder.Seed<ComplexWord>(Hosting.ContentRootPath, "complexWords.json");
            builder.Seed<ComplexWordMap>(Hosting.ContentRootPath, "complexWordMap.json");
            builder.Seed<PreDb>(Hosting.ContentRootPath, "preDb.json");
            builder.Seed<Package>(Hosting.ContentRootPath, "packages.json");
            builder.Seed<Section>(Hosting.ContentRootPath, "sections.json");
            builder.Seed<Site>(Hosting.ContentRootPath, "sites.json");
            builder.Seed<IrcInfo>(Hosting.ContentRootPath, "ircInfo.json");
            builder.Seed<Enrollment>(Hosting.ContentRootPath, "enrollments.json");
            builder.Seed<PackageEnrollment>(Hosting.ContentRootPath, "packageEnrollment.json");
        }
    }
}