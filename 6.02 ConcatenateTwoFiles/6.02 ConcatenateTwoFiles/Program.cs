using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6._02_ConcatenateTwoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader first = new StreamReader(@"../../first.txt");
            StreamReader second = new StreamReader(@"../../second.txt");

            string firstContent = "";
            string secondContent = "";

            using (first)
            {
                firstContent = first.ReadToEnd();
            }
            using (second)
            {
                secondContent = second.ReadToEnd();
            }

            string concatResult = firstContent + secondContent;



            File.WriteAllText(@"../../result.txt", concatResult);

        }
    }
}
