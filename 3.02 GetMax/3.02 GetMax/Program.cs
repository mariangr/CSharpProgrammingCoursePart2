using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._02_GetMax
{
    class Program
    {
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
        return second;
        }



        static void Main(string[] args)
        {
            Console.Write("Write First Number:");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Write Second Number:");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Write Third Number:");
            int third = int.Parse(Console.ReadLine());

            int result = GetMax(first, second);
            result = GetMax(result, third);

            Console.WriteLine(result);

        }
    }
}
