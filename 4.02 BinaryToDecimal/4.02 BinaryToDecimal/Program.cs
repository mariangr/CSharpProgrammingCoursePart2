using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._02_BinaryToDecimal
{
    class Program
    {
        static void BinaryToDecimal(string number)
        {
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                {
                    result += (number[i] - '0') * (int)Math.Pow(2, number.Length - 1 - i);
                }
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Console.Write("Write number:");
            string number = Console.ReadLine();
            
            BinaryToDecimal(number);
        }
    }
}
