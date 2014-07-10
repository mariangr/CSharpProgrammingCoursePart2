using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._02_TenRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = rand.Next(100) + 101;
                Console.WriteLine(number);
            }
        }
    }
}
