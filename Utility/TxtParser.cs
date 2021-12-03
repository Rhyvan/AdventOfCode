using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Utility
{
    public static class TxtParser
    {
        public static IEnumerable<T> ParseFile<T>(string filePath)
        {
            var data = File.ReadLines(filePath);

            if (typeof(T) != typeof(string))
            {
                return data.Select(x => (T)Convert.ChangeType(x, typeof(T)));

            }

            return (IEnumerable<T>) data;
        }
    }
}
