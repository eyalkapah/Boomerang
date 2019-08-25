﻿using System;
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

        public Section[] Sections { get; set; }

        //public Section[] Sections { get; set; }
        public int Type { get; set; }
    }
}