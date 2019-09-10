using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class ComplexWordForCreationDto : WordBaseForCreationDto
    {
        public ICollection<ComplexWordMapForCreationDto> Words { get; set; }
    }
}