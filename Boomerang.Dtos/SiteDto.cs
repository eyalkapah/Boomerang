using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class SiteDto
    {
        public int Id { get; set; }
        public int MaxDownloadLogins { get; set; }
        public int MaxUploadLogins { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public int Status { get; set; }
        public int TotalLogins { get; set; }
        public ICollection<IrcInfoDto> IrcInfo { get; set; }
    }
}