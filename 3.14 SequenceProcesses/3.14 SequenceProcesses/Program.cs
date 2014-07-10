using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14_SequenceProcesses
{
    class Program
    {
        static double Sum(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }

        static int Min(int[] array)
        {
            int result = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (result > array[i])
                {
                    result = array[i];
                }
            }
            return result;
        }

        static int Max(int[] array)
        {
            int result = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (result < array[i])
                {
                    result = array[i];
                }
            }
            return result;
        }

        static int Product(int[] array)
        {
            int result = 1;
            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }
            return result;
        
        }

        static double Average(int[] array)
        {
            double result = Sum(array) / array.Length;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements separated by comma: ");

            int[] sequence = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

            Console.WriteLine(Min(sequence));
            Console.WriteLine(Max(sequence));
            Console.WriteLine(Sum(sequence));
            Console.WriteLine(Average(sequence));
            Console.WriteLine(Product(sequence));
        }
    }
}
