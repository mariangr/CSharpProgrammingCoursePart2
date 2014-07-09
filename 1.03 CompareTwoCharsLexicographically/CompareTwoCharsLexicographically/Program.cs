using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoCharsLexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n'};
            char[] second = { 'a', 'b', 'c', 'd', 'e', 'f', 'y', 'h', 'i', 'j', 'k', 'l', 'm', 'n' };
            bool areEqual = true;
            for (int i = 0; i < first.Length && i < second.Length; i++)
            {
                if (first[i] != second[i])
                {
                    areEqual = false;
                }
            }
            Console.WriteLine(areEqual);

        }
    }
}
