using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class PackageEnrollment
    {
        public Enrollment Enrollment { get; set; }
        public int EnrollmentId { get; set; }
        public Package Package { get; set; }
        public int PackageId { get; set; }
    }
}