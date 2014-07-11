using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6._04_CompareTwoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader first = new StreamReader(@"../../first.txt");
            StreamReader second = new StreamReader(@"../../second.txt");

            string firstContent = first.ReadLine();
            string secondContent = second.ReadLine();
            int equal = 0;
            int notEqual = 0;

            while (firstContent != null /*|| secondContent != null*/)
            {
                if (firstContent == secondContent)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }

                firstContent = first.ReadLine();
                secondContent = second.ReadLine();
            }
            first.Close();
            second.Close();

            Console.WriteLine("Equal: {0}", equal);
            Console.WriteLine("Not Equal: {0}", notEqual);


        }
    }
}
