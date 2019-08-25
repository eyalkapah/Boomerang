using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class Site
    {
        public ICollection<Enrollment> Enrollments { get; set; }

        public int Id { get; set; }

        public ICollection<IrcInfo> IrcInfo { get; set; }
        public int MaxDownloadLogins { get; set; }

        public int MaxUploadLogins { get; set; }

        public string Name { get; set; }

        public int Rank { get; set; }

        public int Status { get; set; }

        public int TotalLogins { get; set; }
    }
}