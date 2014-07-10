using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._06_BinaryToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number:");
            string number = Console.ReadLine();

            Console.WriteLine(Convert.ToString(Convert.ToInt64(number, 2), 16).ToUpper());
        }
    }
}

