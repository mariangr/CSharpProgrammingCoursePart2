using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_DecimalToHexadecimal
{
    class Program
    {
        static string DecimalToHexadecimal(int number)
        {
            List<char> result = new List<char>();

            while (number > 0)
            {
                if (number % 16 >= 10)
                {
                    result.Add((char)('A' + ((number % 16) - 10)));
                }
                else
                {
                    result.Add((char) (number % 16));
                }
                number /= 16;
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 16));

            Console.WriteLine(DecimalToHexadecimal(number));

        }
    }
}
