using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ReadAndPrintLetterIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Char[] array = new char[28];
            int i = 0;
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                array[i] = letter;
                i++;
            }
            Console.Write("Write a word:");
            String word = Console.ReadLine();
            for (int j = 0; j < word.Length; j++)
            {
                char letter = word[j];
                letter = char.ToUpper(letter);
                for (int k = 0; k < array.Length; k++)
                {
                    if (letter == array[k])
                    {
                        Console.WriteLine(letter + ":" + k);
                    }
                }
            }
        }
    }
}
