using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Exceptions
{
    public class DuplicateNameException : Exception
    {
        public DuplicateNameException(string name) : base($"Item named {name} already exists.")
        {
        }
    }
}