using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._04_NumberInArray
{
    class Program
    {
        static int TheFirstBiggerElement(int[] array)
        {
            int? index = null;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0 && i != array.Length - 1)
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        index = i;
                    }
                }
            }

            if (index.HasValue)
            {
                int result = index.Value;
                return result;
            }
            else 
            {
                return -1;
            }
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

            int result = TheFirstBiggerElement(array);

            Console.WriteLine(result);
        }
    }
}
