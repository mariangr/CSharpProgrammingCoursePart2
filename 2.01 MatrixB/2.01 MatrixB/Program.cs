using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_MatrixB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write N:");
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];
            int element = 1;

            for (int j = 0; j < N; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < N; i++)
                    {
                        array[i, j] = element;
                        element++;
                    }
                }
                else
                {
                    for (int i = N - 1; i >= 0; i--)
                    {
                        array[i, j] = element;
                        element++;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
