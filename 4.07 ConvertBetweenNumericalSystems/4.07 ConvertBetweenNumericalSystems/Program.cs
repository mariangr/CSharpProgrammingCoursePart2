using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._07_ConvertBetweenNumericalSystems
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number base s>=2:");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number:");
            string number = Console.ReadLine();

            Console.WriteLine("Enter numeral system base d<=16 to convert to:");
            int d = int.Parse(Console.ReadLine());

            ConvertDecimalToWanted(s, d, number);
        }
        //then convert to wanted base
        static void ConvertDecimalToWanted(int currentBase, int wantedBase, string number)
        {
            int decimalNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                decimalNumber += (number[i] - '0') * (int)Math.Pow(currentBase, number.Length - 1 - i);
            }

            List<string> result = new List<string>();
            string element;
            while (decimalNumber != 0)
            {
                if (decimalNumber % wantedBase > 9)
                {
                    element = ((char)(decimalNumber % wantedBase + 55)).ToString();
                }
                else
                {
                    element = (decimalNumber % wantedBase).ToString();
                }
                result.Add( element );
                decimalNumber /= wantedBase;
            }

            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
