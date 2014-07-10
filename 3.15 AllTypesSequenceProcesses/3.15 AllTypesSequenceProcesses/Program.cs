using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static double Sum<T>(T[] array)
    {
        double result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += Convert.ToDouble(array[i]);
        }
        return result;
    }

    static T Min<T>(T[] array)
    {
        return array.Min();
    }

    static T Max<T>(T[] array)
    {
        return array.Max();
    }

    static double Product<T>(T[] array)
    {
        dynamic result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result *= Convert.ToDouble(array[i]);
        }
        return result;

    }

    static double Average<T>(T[] array)
    {
        dynamic result = Sum(array) / array.Length;
        return result;
    }

    static void Main(string[] args)
        {
            Console.WriteLine("Enter elements separated by comma: ");

            var sequence = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => (x)).ToArray();

            Console.WriteLine("Min: {0}", Min(sequence));
            Console.WriteLine("Max: {0}", Max(sequence));
            Console.WriteLine("Sum: {0}", Sum(sequence));
            Console.WriteLine("Average: {0}", Average(sequence));
            Console.WriteLine("Product: {0}", Product(sequence));
        }

}
