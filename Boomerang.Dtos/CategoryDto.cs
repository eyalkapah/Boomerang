using Boomerang.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class CategoryDto
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SectionDto> Sections { get; set; }

        public CategoryTypeEnum Type { get; set; }
    }
}