using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Context.Extensions
{
    public static class SeedHelpers
    {
        public static void Seed<T>(this ModelBuilder builder, string rootPath, string filename) where T : class
        {
            var path = Path.Combine(rootPath, "Data", filename);

            var json = File.ReadAllText(path);

            var data = JsonConvert.DeserializeObject<List<T>>(json);

            builder.Entity<T>().HasData(data);
        }
    }
}