using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._01_DecimalToBinary
{
    class Program
    {
        static void DecimalToBinary (int number)
        {

            List<int> binaryResult = new List<int>();
            while (number != 0)
            {
                binaryResult.Add(number % 2);
                number /= 2;
            }

            for (int i = binaryResult.Count - 1; i >= 0; i--)
            {
                Console.Write(binaryResult[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Write number:");
            int number = int.Parse(Console.ReadLine());

            DecimalToBinary(number);
        }
    }
}
