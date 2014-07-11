using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6._01_ReadAndPrintOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"../../txt.txt");

            using(streamReader)
            {
                
                int br = 1;
                while (streamReader.Peek() >= 0)
                {
                    string file = streamReader.ReadLine();
                    if (br % 2 == 1)
                    {
                        Console.WriteLine(file);
                    }
                    br++;
                }
            }

            

            

        }
    }
}
