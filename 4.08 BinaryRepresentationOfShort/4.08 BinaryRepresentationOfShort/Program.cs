using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._08_BinaryRepresentationOfShort
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 15; i >= 0; i--)
            {
                if ((number & (1 << i)) != 0)
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(0);
                }
            }
            Console.WriteLine();
        } 
    }
}
