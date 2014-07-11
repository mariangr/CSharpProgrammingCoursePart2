using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6._05_MatrixExercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader(@"../../txt.txt");

            int N = int.Parse(read.ReadLine());

            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                int[] line = read.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            /*
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            */


            int currentSum = int.MinValue;
            int bestSum = int.MinValue;

            if (matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                        if (currentSum > bestSum)
                        {
                            bestSum = currentSum;
                        }
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
