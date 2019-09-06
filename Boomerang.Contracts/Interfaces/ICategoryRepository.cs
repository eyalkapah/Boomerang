using Boomerang.Dtos;
using Boomerang.Dtos.Resources;
using Boomerang.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Contracts.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<CategoryDto> GetCategories(CategoryResources resources);
    }
}