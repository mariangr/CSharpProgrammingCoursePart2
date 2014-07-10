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

            Console.WriteLine(ConvertCurrentToDecimal(s, d, number));
        }
        //convert to decimal first for ease of the convertion
        static string ConvertCurrentToDecimal(int currentBase, int wantedBase, string number)
        {
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                result += (number[i] - '0') * (int)Math.Pow(currentBase, number.Length - 1 - i);
            }

            return ConvertDecimalToWanted(wantedBase, result);
        }
        //then convert to wanted base
        static string ConvertDecimalToWanted(int wantedBase, int number)
        {
            StringBuilder result = new StringBuilder();

            if (wantedBase == 16)
            {
                return Convert.ToString(number, 16).ToUpper();
            }
            else
            {
                while (number > 0)
                {
                    result.Insert(0, number % 16);
                    number /= 16;
                }
            }

            return result.ToString();
        }
    }
}
