using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_MatrixA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write N:");
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N,N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = i + j * N + 1;
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
