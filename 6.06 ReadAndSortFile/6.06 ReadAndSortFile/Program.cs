using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6._06_ReadAndSortFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"../../txt.txt");
            StreamWriter streamWriter = new StreamWriter(@"../../result.txt");
            List<string> readFile = new List<string>();

            string line = streamReader.ReadLine();

            while (line != null)
            {
                readFile.Add(line);
                line = streamReader.ReadLine();
            }
            int i = 0;

            readFile.Sort();

            while (i< readFile.Count)
            {
                string element = readFile[i];
                streamWriter.WriteLine("{0}", element);
                i++;
            }

            streamReader.Close();
            streamWriter.Close();
        }
    }
}