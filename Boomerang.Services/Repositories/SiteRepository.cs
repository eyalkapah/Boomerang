using Boomerang.Context;
using Boomerang.Contracts.Interfaces;
using Boomerang.Dtos.Resources;
using Boomerang.Models.Constants;
using Boomerang.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Repositories
{
    public class SiteRepository : Repository<Site>, ISiteRepository
    {
        public SiteRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Site> GetSites(SiteResources siteResources)
        {
            var query = Set.AsQueryable();
            foreach (var include in siteResources.Includes.Split(','))
            {
                if (string.IsNullOrEmpty(include))
                    continue;

                var val = Mapper.GetValue(include);

                if (include.Equals("enrollments_with_sections"))
                {
                    query = query.Include(c => c.Enrollments)
                        .ThenInclude(x => x.Section);
                }

                if (include.Equals("enrollments_with_packages"))
                {
                    query = query.Include(c => c.Enrollments)
                                .ThenInclude(x => x.Packages)
                                    .ThenInclude(x => x.Package)
                                        .ThenInclude(x => x.ComplexWord)
                               .Include(c => c.Enrollments)
                                .ThenInclude(x => x.Packages)
                                    .ThenInclude(x => x.Package)
                                        .ThenInclude(x => x.Word);
                }

                if (!string.IsNullOrEmpty(val))
                {
                    query = query.Include(val);
                }
            }

            return query;
        }
    }
}