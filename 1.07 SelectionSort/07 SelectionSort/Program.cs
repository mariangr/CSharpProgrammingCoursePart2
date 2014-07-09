using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 8, 6, 1, 9, 1, 8, 321, 8, 3, 21, 56, 2, 4, 9, -10, 6, -5, 5, 9, 1 };
            
            int currentValue = array[0];
            int changeValue;
            int index = 0;

            for (int i = 0; i < array.Length -1; i++)
            {
                int minValue = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    currentValue = array[j];
                    if (minValue > currentValue)
                    {
                        minValue = currentValue;
                        index = j;
                    }
                }
                changeValue = array[i];
                array[i] = minValue;
                array[index] = changeValue;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
