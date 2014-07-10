using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._05_HexadecimalToBinary
{
    class Program
    {
        static List<int> DecimalToBinary(int number)
        {

            List<int> binaryResult = new List<int>();
            while (number != 0)
            {
                binaryResult.Add(number % 2);
                number /= 2;
            }
            return binaryResult;
        }

        static void HexadecimalToBinary(string number)
        {
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > '9')
                {
                    result.Add(DecimalToBinary((int)(number[i] - 'A' + 10)));
                }
                else
                {
                    result.Add(DecimalToBinary((int)(number[i] - '0')));
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                List<int> experiment = result[i]; 
                for (int j = 0; j < experiment.Count; j++)
                {
                    Console.Write(experiment[j]);
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine().ToUpper();

            HexadecimalToBinary(number);
        }
    }
}
