using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._05_SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array elements separated by comma:");
            string[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x.Length).ToArray();

            foreach (var item in array)
            {
                String word = item.Trim();
                Console.WriteLine(word);
            }
        }
    }
}
