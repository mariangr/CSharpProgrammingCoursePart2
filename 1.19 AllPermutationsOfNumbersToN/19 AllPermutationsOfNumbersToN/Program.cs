using System;

class AllPermutationsOfNNumbers
{
    static void Main()
    {
        
        Console.Write("Write the number N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < Math.Pow(N, N); i++)
        {
            int conv = i;
            int[] arrayForPrint = new int[N];
            int[] arrayForSort = new int[N];
            bool print = true;

            for (int j = 0; j < N; j++)
            {
                arrayForPrint[N - j - 1] = conv % N + 1;
                arrayForSort[N - j - 1] = conv % N + 1;
                conv = conv / N;
            }

            Array.Sort(arrayForSort);
            for (int j = 1; j < arrayForSort.Length; j++)
            {
                if (arrayForSort[j] == arrayForSort[j - 1])
                {
                    print = false;
                }
            }

            if (print)
            {
                Console.Write("{0}{1}", '{', arrayForPrint[0]);
                for (uint j = 1; j < N; j++)
                {
                    Console.Write(", {0}", arrayForPrint[j]);
                }
                Console.WriteLine("}");
            }
        }

    }
}