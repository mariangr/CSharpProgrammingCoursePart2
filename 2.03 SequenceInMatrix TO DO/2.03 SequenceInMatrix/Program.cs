using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._03_SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number of rows:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Write number of columns:");
            int col = int.Parse(Console.ReadLine());
            int[,] array = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Write element [ {0} , {1}]: ", i, j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int searchedNumber = array[0, 0];
            int sequenceNumber = 1;
            int maxSequenceNumber = 1;
            int mostFrequentElement = array[0, 0];

            //Rows search
            
            for (int i = 0; i < row; i++)
            {
                sequenceNumber = 1;
                searchedNumber = array[i, 0];
                for (int j = 0; j < col; j++)
                {
                    
                    if (array[i,j] != searchedNumber)
                    {
                        if (maxSequenceNumber < sequenceNumber)
                        {
                            maxSequenceNumber = sequenceNumber;
                            Console.WriteLine("--" + maxSequenceNumber);

                        }
                        searchedNumber = array[i,j];
                        sequenceNumber = 1;
                    }
                    else
                    {
                        sequenceNumber++;
                        if (maxSequenceNumber < sequenceNumber)
                        {
                            mostFrequentElement = array[i, j];
                        }
                    }
                }
            }

            //Columns search
            

            for (int j = 0; j < col; j++)
            {
                sequenceNumber = 1;
                searchedNumber = array[0, j];
                for (int i = 0; i < row; i++)
                {
                    
                    if (array[i, j] != searchedNumber)
                    {
                        if (maxSequenceNumber < sequenceNumber)
                        {
                            maxSequenceNumber = sequenceNumber;
                            Console.WriteLine("|" + maxSequenceNumber);
                        }
                        searchedNumber = array[i, j];
                        sequenceNumber = 1;
                    }
                    else
                    {
                        sequenceNumber++;
                        if (maxSequenceNumber < sequenceNumber)
                        {
                            mostFrequentElement = array[i, j];
                        }
                    }
                }
            }

            //Diagonal (\) search
            int colIndex = 0;
            int rowIndex = row - 1;

            for (int i = 1; i <= row * col; i++)
            {
                
                sequenceNumber = 1;

                try
                {
                    searchedNumber = array[rowIndex, colIndex];
                }
                catch
                {
                    break;
                }

                while (colIndex >= 0 && colIndex < col && rowIndex >= 0 && rowIndex < row)
                {
                    if (array[rowIndex, colIndex] != searchedNumber)
                    {
                        if (maxSequenceNumber < sequenceNumber)
                        {
                            maxSequenceNumber = sequenceNumber;
                            Console.WriteLine(@"\" + maxSequenceNumber);
                        }
                        searchedNumber = array[rowIndex, colIndex];
                        sequenceNumber = 1;
                    }
                    else
                    {
                        sequenceNumber++;
                        if (maxSequenceNumber < sequenceNumber)
                        {
                            mostFrequentElement = array[rowIndex, colIndex];
                        }
                    }
                    rowIndex++;
                    colIndex++;
                }

                rowIndex--;

                while (colIndex != 0 && rowIndex != 0)
                {
                    rowIndex--;
                    colIndex--;
                }


            }


            //Diagonal (/) search
            colIndex = 0;
            rowIndex = 0;

            for (int i = 1; i <= row * col; i++)
            {

                sequenceNumber = 1;

                try
                {
                    searchedNumber = array[rowIndex, colIndex];
                }
                catch
                {
                    break;
                }

                while (colIndex >= 0 && colIndex < col && rowIndex >= 0 && rowIndex < row)
                {
                    if (array[rowIndex, colIndex] != searchedNumber)
                    {
                        if (maxSequenceNumber < sequenceNumber)
                        {
                            maxSequenceNumber = sequenceNumber;
                            Console.WriteLine("/" + maxSequenceNumber);
                        }
                        searchedNumber = array[rowIndex, colIndex];
                        sequenceNumber = 1;
                    }
                    else
                    {
                        sequenceNumber++;
                        if (maxSequenceNumber < sequenceNumber)
                        {
                            mostFrequentElement = array[rowIndex, colIndex];
                        }
                    }
                    rowIndex++;
                    colIndex--;
                }

                colIndex++;

                while (colIndex != 0 && rowIndex != 0)
                {
                    rowIndex--;
                    colIndex++;
                }


            }

            Console.Write("{0}" , mostFrequentElement);
            for (int i = 0; i < maxSequenceNumber - 1; i++)
            {
                Console.Write(" , {0}", mostFrequentElement);
            }
            Console.WriteLine();

        }
    }
}
