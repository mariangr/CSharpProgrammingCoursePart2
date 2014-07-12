using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._04_NumberOfRepeatitionSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write text: ");
            string text = Console.ReadLine();
            Console.Write("Write word to search: ");
            string word = Console.ReadLine();
            int br = 0;

            for (int i = 0; i < text.Length - word.Length; i++)
            {
                if ((text.Substring(i, word.Length).ToUpper()) == (word.ToUpper()))
                { 
                    br++;
                }
            }

            Console.WriteLine("Number of repetitions: " + br);
        }
    }
}
