using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._06_ReadAndSumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int array elements separated by mpty space:");
            int[] array = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
