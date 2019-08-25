using Boomerang.Context;
using Boomerang.Contracts.Interfaces;
using Boomerang.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Repositories
{
    public class PreDbRepository : Repository<PreDb>, IPreDbRepository
    {
        public PreDbRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}