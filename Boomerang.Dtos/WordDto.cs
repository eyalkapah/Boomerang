using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class WordDto : WordBaseDto
    {
        //public ICollection<ComplexWordMap> ComplexWords { get; set; }
        public string IgnorePattern { get; set; }

        //public ICollection<Package> Packages { get; set; }
        public string Pattern { get; set; }
    }
}