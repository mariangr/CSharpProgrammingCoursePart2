using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._06_StringReadAndPrint6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Write text with max 20 characters: ");
                string text = Console.ReadLine();

                if (text.Length > 20)
                {
                    throw new ArgumentException("The text must be under 20 characters");
                }

                StringBuilder result = new StringBuilder();

                if (text.Length < 20)
                {

                    for (int i = 0; i < text.Length; i++)
                    {
                        result.Append(text[i]);
                    }
                    int rest = 20 - text.Length;
                    for (int i = 0; i < rest; i++)
                    {
                        result.Append('*');
                    }
                }
                Console.WriteLine();
                Console.WriteLine(result.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
