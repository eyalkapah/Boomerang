using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class PackageEnrollmentDto
    {
        //public Enrollment Enrollment { get; set; }
        //public int EnrollmentId { get; set; }
        public PackageDto Package { get; set; }

        public int PackageId { get; set; }
    }
}