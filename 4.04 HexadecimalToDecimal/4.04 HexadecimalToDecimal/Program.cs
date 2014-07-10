using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._04_HexadecimalToDecimal
{
    class Program
    {
        static long ConvertToDecimal(string hexadecimal)
        {
            long result = 0;

            for (int i = 0; i < hexadecimal.Length; i++)
            {
                if (hexadecimal[i] > '9')
                {
                    result += (hexadecimal[i] - 'A' + 10) * (int)Math.Pow(16, hexadecimal.Length - 1 - i);
                }
                else
                {
                    result += (hexadecimal[i] - '0') * (int)Math.Pow(16, hexadecimal.Length - 1 - i);
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine().ToUpper();

            Console.WriteLine(ConvertToDecimal(hexadecimal));
        }
        
    }
}
