using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FindAGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4, 3, 1, 4, 2, 5, 8};
            int S = 11;
            int sum = 0;
            int final = 0, index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    if (sum == S)
                    {
                        index = i;
                        final = j;
                        
                    }
                }
                sum = 0;
            }
            for (int i = index; i <= final; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
