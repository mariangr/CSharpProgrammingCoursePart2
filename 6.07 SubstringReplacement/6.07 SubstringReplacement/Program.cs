using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _6._07_SubstringReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../txt.txt";
            var fileContents = Regex.Replace(File.ReadAllText(filePath), "start", "finish", RegexOptions.IgnoreCase);
            File.WriteAllText(filePath, fileContents);
        }
    }
}
