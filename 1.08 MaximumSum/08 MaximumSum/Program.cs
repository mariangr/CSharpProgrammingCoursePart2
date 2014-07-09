using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int maxSum = 0;
            int currentSum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    currentSum += array[j];
                }
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
                currentSum = 0;
            }
            Console.WriteLine(maxSum);
        }
    }
}
