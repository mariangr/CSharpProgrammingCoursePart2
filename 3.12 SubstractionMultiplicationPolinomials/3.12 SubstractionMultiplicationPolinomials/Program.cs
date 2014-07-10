using System;
using System.Linq;

class Polinomials
{
    static decimal[] SubstractPolinomials(decimal[] first, decimal[] second)
    {
        int maxLength = Math.Max(first.Length, second.Length);
        decimal[] result = new decimal[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            if (i < first.Length && i < second.Length)
            {
                result[i] = first[i] - second[i];
            }
            else if (i >= first.Length)
            {
                result[i] = second[i];
            }
            else if (i >= second.Length)
            {
                result[i] = first[i];
            }
        }
        return result;
    }

    static void PrintResult(decimal[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            if (array[i] != 0)
            {
                Console.Write("{0}x^{1}", array[i], i);
            }

            if (i > 0 && array[0] != 0 && array[i] != 0)
            {
                Console.Write(" + ");
            }
        }

        if (array[0] != 0)
        {
            Console.Write(array[0]);
        }

        Console.WriteLine(" = 0");
    }


    static void Main()
    {
        Console.WriteLine("Enter first polinomial coeficients:");
        decimal[] first = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToDecimal(x)).ToArray();

        Console.WriteLine("Enter second polinomial coeficients:");
        decimal[] second = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToDecimal(x)).ToArray();

        PrintResult(SubstractPolinomials(first, second));
    }

}