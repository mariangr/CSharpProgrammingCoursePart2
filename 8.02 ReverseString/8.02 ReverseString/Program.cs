using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._02_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something");
            string something = Console.ReadLine();
            char[] newChar = something.ToCharArray();
            Array.Reverse(newChar);
            string newReversedString = new string(newChar);
            Console.WriteLine("New Reversed String: " + newReversedString);


        }
    }
}
