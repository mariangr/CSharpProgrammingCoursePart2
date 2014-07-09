using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._01_MatrixC
{
    class Program
    {
        static void Move(int[,] array,int N, int row, int col, int element)
        {
            for (int i = 1; i <= N * N; i++ )
            {
                
                while (col >= 0 && col < N && row >= 0 && row < N)
                {
                    array[row, col] = element;
                    element++;
                    row++;
                    col++;
                }
                col--;

                while (col != 0 && row != 0)
                {
                    row--;
                    col--;
                }

            }
        }

        static void Main(string[] args)
        {
            Console.Write("Write N:");
            int N = int.Parse(Console.ReadLine());
            int[,] array = new int[N, N];

            int startRow = 0;
            int startCol = N - 1;

            Move(array, N, startRow, startCol, 1);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
