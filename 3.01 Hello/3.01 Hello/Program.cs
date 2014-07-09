using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._01_Hello
{
    class Program
    {
        static void HelloPerson()
        {
            Console.Write("Write your name:");
            String name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        
        }


        static void Main(string[] args)
        {
            HelloPerson();
        }
    }
}
