using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class Package
    {
        public int Applicability { get; set; }
        public ComplexWord ComplexWord { get; set; }
        public int? ComplexWordId { get; set; }
        public string Description { get; set; }

        public ICollection<PackageEnrollment> Enrollments { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<Section> Sections { get; set; }
        public Word Word { get; set; }
        public int? WordId { get; set; }
    }
}