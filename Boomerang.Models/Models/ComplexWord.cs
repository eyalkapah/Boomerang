using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class ComplexWord : WordBase
    {
        public ICollection<Package> Packages { get; set; }
        public ICollection<Word> Words { get; set; }
    }
}