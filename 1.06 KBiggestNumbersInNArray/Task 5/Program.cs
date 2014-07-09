using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write N:");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Write K:");
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Input array[{0}]=", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int i = array.Length - 1; i > array.Length - K - 1; i--)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
