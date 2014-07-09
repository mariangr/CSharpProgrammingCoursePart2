using System;

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5, 4};
            int searchedNumber = array[0];
            int sequenceNumber = 1;
            int maxSequenceNumber = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > searchedNumber)
                {
                    sequenceNumber++;
                }
                else
                {
                    sequenceNumber = 1;
                }
                if (maxSequenceNumber < sequenceNumber)
                {
                    maxSequenceNumber = sequenceNumber;
                }
                searchedNumber = array[i];
            }
            Console.WriteLine(maxSequenceNumber);
        }
    }
}
