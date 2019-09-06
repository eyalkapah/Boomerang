using AutoMapper;
using Boomerang.Configurations.Configurations;
using Boomerang.Context;
using Boomerang.Contracts.Interfaces;
using Boomerang.Dtos;
using Boomerang.Dtos.Resources;
using Boomerang.Models.Models;
using Boomerang.Services.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly Dictionary<string, Action> _constants = new Dictionary<string, Action>();
        private readonly IMapper _mapper;
        private IQueryable<Category> _query;

        public CategoryRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;

            _query = Set.AsQueryable();

            _constants.Add("sections", () => _query = _query.QuerySections());
            _constants.Add("enrollments", () => _query = _query.QueryEnrollments());
            _constants.Add("sites", () => _query = _query.QuerySites());
        }

        public IEnumerable<CategoryDto> GetCategories(CategoryResources resources)
        {
            if (resources.Includes != null)
            {
                foreach (var item in resources.Includes?.Split(','))
                {
                    _constants.TryGetValue(item.ToLower(), out Action action);

                    action?.Invoke();
                }
            }

            var dto = _mapper.Map<IEnumerable<CategoryDto>>(_query);

            return dto;
        }
    }
}