using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _6._08_WordReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../txt.txt";
            Console.WriteLine("Content: ");
            StreamReader read = new StreamReader(filePath);
            string content = read.ReadToEnd();
            read.Close();
            Console.WriteLine();
            Console.WriteLine(content);
            Console.WriteLine();


            Console.Write("Write word to replace: ");
            string first = Console.ReadLine();
            Console.Write("Write word to replace with: ");
            string second = Console.ReadLine();

            
            var fileContents = Regex.Replace(File.ReadAllText(filePath), first, second, RegexOptions.IgnoreCase);
            File.WriteAllText(filePath, fileContents);
        }
    }
}
