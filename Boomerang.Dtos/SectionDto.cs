using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class SectionDto
    {
        public int BubbleLevel { get; set; }

        public char Delimiter { get; set; }
        public string Description { get; set; }
        public ICollection<EnrollmentDto> Enrollments { get; set; }

        public int Id { get; set; }

        public bool IsEnabled { get; set; }

        public string Name { get; set; }

        public PackageDto Package { get; set; }

        public int PackageId { get; set; }

        //public string PackageId { get; set; }
        public int RaceActivityInSeconds { get; set; }
    }
}