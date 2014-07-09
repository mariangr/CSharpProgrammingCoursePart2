using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInputAndCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the size of the arrays:");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("firstArray[{0}]=", i);
                firstArray[i] = int.Parse(Console.ReadLine());
                Console.Write("secondArray[{0}]=", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            bool areTheSame = true;
            for (int i = 0; i < n; i++)
            {
                if (secondArray[i] != firstArray[i])
                {
                    areTheSame = false;
                }
            }
            if (areTheSame)
            {
                Console.WriteLine("The elements of the arrays are equal.");
            }
            else
            {
                Console.WriteLine("The elements of the arrays are not equal.");
            }
        }
    }
}
