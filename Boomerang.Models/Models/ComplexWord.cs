using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class ComplexWord : WordBase
    {
        public Package[] Packages { get; set; }
        public Word[] Words { get; set; }
    }
}