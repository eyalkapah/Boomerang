using Boomerang.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Queries
{
    public static class CategoryQueries
    {
        public static IQueryable<Category> QueryEnrollments(this IQueryable<Category> query)
        {
            query = query.Include(x => x.Sections).ThenInclude(x => x.Enrollments).ThenInclude(x => x.Packages).ThenInclude(x => x.Package).ThenInclude(x => x.Word);

            query = query.Include(x => x.Sections).ThenInclude(x => x.Enrollments).ThenInclude(x => x.Packages).ThenInclude(x => x.Package).ThenInclude(x => x.ComplexWord);

            return query;
        }

        public static IQueryable<Category> QuerySections(this IQueryable<Category> query) => query.Include(x => x.Sections).ThenInclude(x => x.Package).ThenInclude(x => x.Word);

        public static IQueryable<Category> QuerySites(this IQueryable<Category> query) => query.Include(x => x.Sections).ThenInclude(x => x.Enrollments).ThenInclude(x => x.Site).ThenInclude(x => x.IrcInfo);
    }
}