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
        public IReleaseRepository Releases { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            Releases = new ReleaseRepository(context);
        }
    }
}