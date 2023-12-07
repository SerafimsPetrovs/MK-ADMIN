using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKadmin
{
    internal class FileManager
    {
        public static string CombinePaths(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }

        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public static string[] ReadAllLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        public static void AppendTextToFile(string filePath, string text)
        {
            File.AppendAllText(filePath, text + "\n");
        }
    }
}