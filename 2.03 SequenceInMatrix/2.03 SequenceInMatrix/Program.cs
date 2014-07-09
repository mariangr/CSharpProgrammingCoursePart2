using System;
using System.Linq;

namespace Sequences
{
    class Sequences
    {
        static void Main(string[] args)
        {
            //string[,] matrix = new string[,] { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };
            string[,] matrix = new string[,] { { "s", "qq", "s" }, { "pp", "pp", "s" }, { "pp", "qq", "s" } };
            //string[,] matrix = new string[,] {{ "pop", "trip", "hop", "trop" }, { "ha", "hi", "trop", "hi" }, { "ho", "trop", "he", "ha" }, { "trop", "hum", "hum", "hum" }};
            //string[,] matrix = new string[,] { { "pop", "pop", "ha", "ha" }, { "pop", "pop", "ha", "hi" }, { "pop", "ha", "pop", "hi" }, { "ha", "hi", "hi", "pop" } };

            int currentSeq = 1;
            int maxSeq = 1;
            string maxElement = "element";

            //check all ROWS
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    if (matrix[rows, cols] == matrix[rows, cols + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                    }
                }
                currentSeq = 1;
            }

            //check all COLLUMNS
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }

                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[rows, cols];
                    }
                }
                currentSeq = 1;
            }

            //check all diagonals (/)
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1; rows++, cols++)
                    {
                        if (matrix[rows, cols] == matrix[rows + 1, cols + 1])
                        {
                            currentSeq++;
                        }
                        else
                        {
                            currentSeq = 1;
                        }

                        if (maxSeq < currentSeq)
                        {
                            maxSeq = currentSeq;
                            maxElement = matrix[rows, cols];
                        }
                    }
                    currentSeq = 1;
                }
            }

            //check all diagonals (\)
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (matrix[rows, cols] == matrix[rows + 1, cols - 1])
                        {
                            currentSeq++;
                        }
                        else
                        {
                            currentSeq = 1;
                        }

                        if (maxSeq < currentSeq)
                        {
                            maxSeq = currentSeq;
                            maxElement = matrix[rows, cols];
                        }
                    }
                    currentSeq = 1;
                }
            }
            Console.Write("{0}", maxElement);
            for (int i = 1; i < maxSeq; i++)
            {
                Console.Write(", {0}", maxElement);
            }
            Console.WriteLine();
        }
    }
}