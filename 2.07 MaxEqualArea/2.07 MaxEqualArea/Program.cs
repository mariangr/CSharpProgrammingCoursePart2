﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._07_MaxEqualArea
{
    class Program
    {
        static int bestLength = 0;
        static int currentLength = 0;
        static int[,] directions = { { 1, 0 }, { 0, 1 }, { 0, -1 }, { -1, 0 } };
        static bool[,] isVisited;
        static int[,] matrix;
        static void Main()
        {
            Console.WriteLine("Enter width:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter heigth:");
            int heigth = int.Parse(Console.ReadLine());

            matrix = new int[heigth, width];

            for (int row = 0; row < heigth; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write("Element [{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            isVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!isVisited[row, col])
                    {
                        currentLength = 0;

                        DepthFIrstSearch(row, col);

                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                        }
                    }
                }
            }
            Console.WriteLine(bestLength);
        }

        static void DepthFIrstSearch(int row, int col)
        {
            int currentNumber = matrix[row, col];
            currentLength++;
            isVisited[row, col] = true;

            for (int directionsIndex = 0; directionsIndex < directions.GetLength(0); directionsIndex++)
            {
                int nextRow = row + directions[directionsIndex, 0];
                int nextCol = col + directions[directionsIndex, 1];

                if (IsTraversable(nextRow, nextCol) && (matrix[nextRow, nextCol] == currentNumber) && !isVisited[nextRow, nextCol])
                {
                    DepthFIrstSearch(nextRow, nextCol);
                }
            }
        }
        static bool IsTraversable(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
