using Boomerang.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class Enrollment
    {
        public string Affils { get; set; }
        public int Id { get; set; }

        public ICollection<PackageEnrollment> Packages { get; set; }
        public Section Section { get; set; }

        public int SectionId { get; set; }
        public Site Site { get; set; }
        public int SiteId { get; set; }
        public EnrollmentStatus Status { get; set; }
    }
}