using System;

class Program
{
    
    static void Variations(int[] array, int index, int N)
    {
        if (index == array.Length)
        {
            bool isRepeating = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        isRepeating = true;

                    }
                }

            }
            if (!isRepeating)
            {
                PrintArray(array);
            }
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                array[index] = i;
                Variations(array, index + 1, N);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Write N:");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Write K:");
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[K];
        Variations(array, 0, N);

    }
}
