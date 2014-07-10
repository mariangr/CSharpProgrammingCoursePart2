using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._01_IsALeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write year to check: ");
            Console.WriteLine("This is " + (DateTime.IsLeapYear(int.Parse(Console.ReadLine())) ? "" : "not ") + "a leap year.");
        }
    }
}
