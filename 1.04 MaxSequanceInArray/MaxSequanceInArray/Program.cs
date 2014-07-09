using System;

namespace MaxSequanceInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 2, 2, 4, 5, 8, 6, 6, 6, 6, 6, 6, 4, 5, 9, 10, 11 };
            int searchedNumber = array[0];
            int sequenceNumber = 1;
            int maxSequenceNumber = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != searchedNumber)
                {
                    if (maxSequenceNumber < sequenceNumber)
                    {
                        maxSequenceNumber = sequenceNumber;
                    }
                    searchedNumber = array[i];
                    sequenceNumber = 1;
                }
                else
                {
                    sequenceNumber++;
                }
            }
            Console.WriteLine(maxSequenceNumber);
        }
    }
}
