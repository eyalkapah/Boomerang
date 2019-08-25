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
    public class ComplexWordRepository : Repository<ComplexWord>, IComplexWordRepository
    {
        public ComplexWordRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}