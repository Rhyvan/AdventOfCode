using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Utility
{
    public static class GetDataFromSource
    {
        private static string workingDirectory = Environment.CurrentDirectory;
        private static string root = workingDirectory.Substring(0, workingDirectory.LastIndexOf(@"\bin"));

        public static IEnumerable<T> Get<T>(string fileName)
        {
            return TxtParser.ParseFile<T>(GetFilePath(fileName));
        }

        public static string GetFilePath(string fileName) => Path.Combine(root + ConfigurationManager.AppSettings["InputFiles"], fileName);

    }
}
