using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10_Factorial
{
    class Program
    {
        static ulong Factorial(uint n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else
            {
                return Factorial(n - 1)*n;
            }
        }

        static void AllFactorialsOneToHundred()
        {
            for (uint i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}!= {1}", i, Factorial(i));
            }
        }


        static void Main(string[] args)
        {
            AllFactorialsOneToHundred();
        }
    }
}
