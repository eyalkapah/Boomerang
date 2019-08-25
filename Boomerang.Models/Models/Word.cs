using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class Word : WordBase
    {
        public string Pattern { get; set; }
        public string IgnorePattern { get; set; }
        public ComplexWord ComplexWord { get; set; }
        public int ComplexWordId { get; set; }
    }
}