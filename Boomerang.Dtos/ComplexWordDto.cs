using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class ComplexWordDto : WordBaseDto
    {
        //public ICollection<Package> Packages { get; set; }

        [JsonProperty(Order = 5)]
        public ICollection<ComplexWordMapDto> Words { get; set; }
    }
}