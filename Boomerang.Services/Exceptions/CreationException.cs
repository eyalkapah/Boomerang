﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Exceptions
{
    public class CreationException : Exception
    {
        public CreationException(string message) : base(message)
        {
        }
    }
}