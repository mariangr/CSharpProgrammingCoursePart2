using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _6._11_DeleteAllWordeWithPrefixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../txt.txt";

            var fileContents = Regex.Replace(File.ReadAllText(filePath), @"\btest[a-zA-z_]+", "", RegexOptions.IgnoreCase);

            File.WriteAllText(filePath, fileContents);
        }
    }
}
