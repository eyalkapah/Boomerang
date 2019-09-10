using AutoMapper;
using Boomerang.Context;
using Boomerang.Contracts.Interfaces;
using Boomerang.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ICategoryRepository Categories { get; set; }
        public IComplexWordRepository ComplexWords { get; set; }
        public IEnrollmentRepository Enrollments { get; set; }
        public IPackageRepository Packages { get; set; }
        public IPreDbRepository PreDbs { get; set; }
        public IReleaseRepository Releases { get; set; }
        public ISiteRepository Sites { get; set; }
        public IWordRepository Words { get; set; }

        public IMapper Mapper { get; set; }

        public UnitOfWork(ApplicationDbContext context, IMapper mapper)
        {
            Releases = new ReleaseRepository(context);
            Sites = new SiteRepository(context);
            Categories = new CategoryRepository(context, mapper);
            Words = new WordRepository(context, mapper);
            ComplexWords = new ComplexWordRepository(context, mapper);
            Packages = new PackageRepository(context);
            Enrollments = new EnrollmentRepository(context);
            PreDbs = new PreDbRepository(context);
            _context = context;
            Mapper = mapper;
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}