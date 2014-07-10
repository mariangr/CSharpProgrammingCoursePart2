using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._04_NumberInArray
{
    class Program
    {
        static bool IsTheElementBigger(int[] array, int index)
        {
            bool isBigger = false;
            if (index != 0 && index != array.Length - 1)
            {
                if (array[index] > array[index - 1] && array[index] > array[index + 1])
                {
                    isBigger = true;
                }
            }

                return isBigger;
        }



        static void Main(string[] args)
        {
            Console.Write("Write size of array:");
            int[] array = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Write array[{0}]:", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Write index to check:");
            int searchedIndex = int.Parse(Console.ReadLine());

            bool result = IsTheElementBigger(array, searchedIndex);

            Console.WriteLine(result);
        }
    }
}
