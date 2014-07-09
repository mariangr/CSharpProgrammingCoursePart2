using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._04_BinSearch
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

            int index = Array.BinarySearch(array, K);


            if (index > 0) 
            {
                Console.WriteLine(array[index - 1]);
            }
            else if (index == -1 || index == 0) 
            {
                Console.WriteLine("Not Found");
            }
            else if (index < -1) 
            {
                Console.WriteLine(array[Math.Abs(index) - 2]);
            }
        }
    }
}
