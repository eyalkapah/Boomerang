using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class IrcInfo
    {
        public string Bot { get; set; }
        public string Channel { get; set; }
        public int Id { get; set; }
        public Site Site { get; set; }
        public int SiteId { get; set; }
    }
}