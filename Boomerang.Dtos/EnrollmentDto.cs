using Boomerang.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class EnrollmentDto
    {
        public string Affils { get; set; }
        public int Id { get; set; }

        public ICollection<PackageEnrollmentDto> Packages { get; set; }
        //public Section Section { get; set; }

        //public int SectionId { get; set; }

        public SiteDto Site { get; set; }
        public int SiteId { get; set; }

        public EnrollmentStatusEnum Status { get; set; }
    }
}