using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6._09_DeleteAllOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../txt.txt";
            string[] allLines = File.ReadAllLines(filePath);

            for (int i = 0; i < allLines.Length; i++)
            {
                if (i % 2 == 0)
                {
                    allLines[i] = null;
                }
            }

            File.WriteAllLines(filePath, allLines);
        }
    }
}
