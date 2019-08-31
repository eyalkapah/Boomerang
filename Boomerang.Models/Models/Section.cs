using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class Section
    {
        public int BubbleLevel { get; set; }

        // Foreign keys
        public Category Category { get; set; }

        public int CategoryId { get; set; }
        public char Delimiter { get; set; }
        public string Description { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

        public int Id { get; set; }

        public bool IsEnabled { get; set; }

        public string Name { get; set; }

        public Package Package { get; set; }

        public int PackageId { get; set; }

        //public string PackageId { get; set; }
        public int RaceActivityInSeconds { get; set; }
    }
}