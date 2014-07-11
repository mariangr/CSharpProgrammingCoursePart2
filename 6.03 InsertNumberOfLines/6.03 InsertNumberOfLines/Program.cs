using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6._03_InsertNumberOfLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"../../txt.txt");
            StreamWriter streamWriter = new StreamWriter(@"../../result.txt");

            using (streamReader)
            {
                using (streamWriter)
                {
                    string line = streamReader.ReadLine();
                    int br = 1;
                    while (line != null)
                    {

                        streamWriter.WriteLine("{0}:{1}", br, line);
                        line = streamReader.ReadLine();
                        br++;
                    }
                }
            }
        }
    }
}
