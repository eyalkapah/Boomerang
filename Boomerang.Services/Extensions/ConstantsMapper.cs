using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services.Extensions
{
    public static class ConstantsMapper
    {
        public static string GetValue(this Dictionary<string, string> map, string key)
        {
            map.TryGetValue(key.ToLower(), out string val);

            return val;
        }
    }
}