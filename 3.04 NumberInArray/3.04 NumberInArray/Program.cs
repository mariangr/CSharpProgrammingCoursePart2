using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._04_NumberInArray
{
    class Program
    {
        static int Count(int[] array, int number)
        {
            int br = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == number)
                {
                    br++;
                }
            }
            return br;
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

            Console.Write("Write number to search:");
            int searchedNumber = int.Parse(Console.ReadLine());

            int br = Count(array, searchedNumber);

            Console.WriteLine("The array has {0} in it {1} times",searchedNumber, br);
        }
    }
}
