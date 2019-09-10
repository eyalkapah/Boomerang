using Boomerang.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Queries
{
    public static class ComplexWordQueries
    {
        public static IQueryable<ComplexWord> QueryWords(this IQueryable<ComplexWord> query) => query.Include(x => x.Words).ThenInclude(x => x.Word);
    }
}