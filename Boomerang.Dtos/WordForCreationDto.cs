using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Dtos
{
    public class WordForCreationDto
    {
        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Description { get; set; }

        [Required]
        [MaxLength(64)]
        public string Classification { get; set; }

        [MaxLength(2048)]
        public string IgnorePattern { get; set; }

        [Required]
        [MaxLength(2048)]
        public string Pattern { get; set; }
    }
}