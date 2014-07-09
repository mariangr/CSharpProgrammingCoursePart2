using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_MatrixD
{
    class Program
    {
        static void WriteMatrix(int[,] array, int N)
        {
            int element = 1;
            int row = 0;
            int col = 0;
            int cycle = 0;
            while(element <= N*N)
            {
                while (row != N - 1 - cycle)
                {
                    if (element >= N * N)
                    {
                        break;
                    }
                    array[row, col] = element;
                    
                    element++;
                    row++;
                }
                
                while (col != N - 1 - cycle)
                {
                    if (element > N * N)
                    {
                        break;
                    }
                    array[row, col] = element;
                    element++;
                    col++;
                }

                while (row != cycle)
                {
                    if (element >= N * N)
                    {
                        break;
                    }
                    array[row, col] = element;
                    element++;
                    row--;
                }
                cycle++;

                while (col != cycle)
                {
                    if (element >= N * N)
                    {
                        break;
                    }
                    array[row, col] = element;
                    element++;
                    col--;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Write N:");
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];

            WriteMatrix(array, N);

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
