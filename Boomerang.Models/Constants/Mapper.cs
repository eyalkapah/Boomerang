using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models.Constants
{
    public class Mapper
    {
        private static Dictionary<string, string> _map = new Dictionary<string, string>
        {
            { "ircinfo", "IrcInfo" },
            {"enrollments", "Enrollments" },
            {"section", "Section" },
        };

        public static string GetValue(string key)
        {
            _map.TryGetValue(key.ToLower(), out string val);

            return val;
        }
    }
}