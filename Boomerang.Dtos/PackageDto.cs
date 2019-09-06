using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class PackageDto
    {
        public int Applicability { get; set; }

        public ComplexWordDto ComplexWord { get; set; }
        public int? ComplexWordId { get; set; }

        public string Description { get; set; }

        //public ICollection<PackageEnrollment> Enrollments { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }

        //public ICollection<Section> Sections { get; set; }
        public WordDto Word { get; set; }

        public int? WordId { get; set; }
    }
}