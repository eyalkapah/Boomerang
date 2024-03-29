﻿using Boomerang.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Models
{
    public class Category
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Section> Sections { get; set; }

        public CategoryTypeEnum Type { get; set; }
    }
}