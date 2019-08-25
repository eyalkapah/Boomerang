using Boomerang.Context;
using Boomerang.Contracts.Interfaces;
using Boomerang.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Repositories
{
    public class ReleaseRepository : Repository<Release>, IReleaseRepository
    {
        public ReleaseRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}