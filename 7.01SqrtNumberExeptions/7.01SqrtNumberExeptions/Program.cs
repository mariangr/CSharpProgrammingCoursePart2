using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._01SqrtNumberExeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number to find the square root: ");

            try
            {
                int N = int.Parse(Console.ReadLine());
                if(N<0)
                {
                    throw new ArgumentException("Number must be > 0");
                }
                double result = Math.Sqrt(N);
                Console.WriteLine(result);
                
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Error: " + oe.Message);

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid Number: " + fe.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Invalid Number: " + ae.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
