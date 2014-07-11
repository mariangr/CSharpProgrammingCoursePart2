using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6._10_ExtractFromXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            string filePath = @"../../XML.xml";
            using (StreamReader xmlFile = new StreamReader(filePath))
            {
                int currentChar;

                while ((currentChar = xmlFile.Read()) != -1)
                {
                    if (currentChar == '>')
                    {
                        while ((currentChar = xmlFile.Read()) != -1 && currentChar != '<')
                        {
                            result.Append((char)currentChar);
                        }
                    }

                    if (result.ToString() != Environment.NewLine && result.ToString() != String.Empty)
                    {
                        Console.WriteLine(result.ToString().Trim());
                    }

                    result.Clear();
                }
            } 
        }
    }
}
