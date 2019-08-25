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
        public ICategoryRepository Categories { get; set; }
        public IReleaseRepository Releases { get; set; }
        public ISiteRepository Sites { get; set; }
        public IWordRepository Words { get; set; }
        public IComplexWordRepository ComplexWords { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            Releases = new ReleaseRepository(context);
            Sites = new SiteRepository(context);
            Categories = new CategoryRepository(context);
            Words = new WordRepository(context);
            ComplexWords = new ComplexWordRepository(context);
        }
    }
}