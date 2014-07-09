using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._02_RectangularMatrix
{
    class Program
    {
        static int[,] array;

        static int SumInSquare(int row, int col)
        {
            int result = 0;

            for (int i = row; i < 3 + row; i++)
            {
                for (int j = col; j < 3 + col; j++)
                {
                    result += array[i, j];
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Write number of rows:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Write number of columns:");
            int col = int.Parse(Console.ReadLine());
            array = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Write element [ {0} , {1}]: ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int currentSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i <= row - 3; i++)
            {
                for (int j = 0; j <= col - 3; j++)
                {
                    currentSum = SumInSquare(i, j);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}

