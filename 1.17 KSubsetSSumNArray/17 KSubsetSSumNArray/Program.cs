using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write Size of array:");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Write Sum:");
            int S = int.Parse(Console.ReadLine());
            Console.Write("Write Number of elements:");
            int K = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Write {0} element in the array:" , i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;

            int variation = (int)Math.Pow(2, N) - 1;

            for (int i = 1; i <= variation; i++)
            {
                string binaryI = Convert.ToString(i, 2).PadLeft(N, '0');
                long result = 0;
                string strResult = "";
                int br = 0;

                for (int j = 0; j < N; j++)
                {
                    
                    if (binaryI[j] == '1')
                    {
                        result += array[j];
                        strResult += array[j] + " + ";
                        br++;
                    }
                }

                if (result == S && br == K)
                {
                    strResult = strResult.Remove(strResult.Length - 3);
                    Console.WriteLine("yes ({0})", strResult);
                    counter++;
                }
            }
        }
    }

}

