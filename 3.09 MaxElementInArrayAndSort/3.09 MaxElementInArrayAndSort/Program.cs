using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._09_MaxElementInArrayAndSort
{
    class Program
    {
        static int FindMaxInRange(int[] array, int startIndex, int endIndex)
        {
            int maxElement = int.MinValue;
            int index = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                    index = i;
                }
            }
            return index;
        }

        static void DescendingSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = FindMaxInRange(array, i, array.Length - 1);
                int temp = array[index];
                array[index] = array[i];
                array[i] = temp;

            }

        }

        static void AscendingSort(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int index = FindMaxInRange(array, 0, i);
                int temp = array[index];
                array[index] = array[i];
                array[i] = temp;

            }

        }

        static void PrintResult(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 && array[i] == 0)
                {
                    continue;
                }
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 78, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            PrintResult(array);

            DescendingSort(array);
            PrintResult(array);

            AscendingSort(array);
            PrintResult(array);

            Console.WriteLine();

        }
    }
}
