using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class Word : WordBase
    {
        public ICollection<ComplexWordMap> ComplexWords { get; set; }
        public string IgnorePattern { get; set; }
        public ICollection<Package> Packages { get; set; }
        public string Pattern { get; set; }
    }
}