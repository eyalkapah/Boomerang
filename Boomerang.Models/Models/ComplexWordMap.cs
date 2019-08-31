using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class ComplexWordMap
    {
        public ComplexWord ComplexWord { get; set; }
        public int ComplexWordId { get; set; }
        public Word Word { get; set; }
        public int WordId { get; set; }
    }
}