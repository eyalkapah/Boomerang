using AutoMapper;
using Boomerang.Configurations.Configurations;
using Boomerang.Context;
using Boomerang.Contracts.Interfaces;
using Boomerang.Dtos;
using Boomerang.Dtos.Resources;
using Boomerang.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly IMapper _mapper;

        private Dictionary<string, string> _constants = new Dictionary<string, string>
        {
            { "sections", "Sections" }
        };

        public CategoryRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public IEnumerable<CategoryDto> GetCategories(CategoryResources resources)
        {
            var query = Set.AsQueryable();

            var categories = query.Include(x => x.Sections).ThenInclude(x => x.Package)
                .ThenInclude(x => x.Word)
                .Include(x => x.Sections).ThenInclude(x => x.Package).ThenInclude(x => x.ComplexWord)
                .Include(x => x.Sections).ThenInclude(x => x.Enrollments).ThenInclude(x => x.Site).ThenInclude(x => x.IrcInfo)
                .Include(x => x.Sections).ThenInclude(x => x.Enrollments).ThenInclude(x => x.Packages).ThenInclude(x => x.Package).ThenInclude(x => x.Word)
                .ToList();

            var dto = _mapper.Map<IEnumerable<CategoryDto>>(categories);

            return dto;
        }
    }
}