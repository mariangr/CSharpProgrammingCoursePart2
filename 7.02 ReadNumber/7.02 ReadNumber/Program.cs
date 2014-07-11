using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._02_ReadNumber
{
    class Program
    {
        static int ReadNumber(int start, int end)
        {
            try
            {
                if (end - start == 0)
                {
                    throw new ArgumentOutOfRangeException("You can't write any numbers. The array will be filled with the minimum int number.");
                }
                Console.Write("Enter number: ");
                int N = int.Parse(Console.ReadLine());
                if (N < start || N > end)
                {
                    throw new ArgumentException("The number must be between " + start + " and " + end + "!");
                }
                
                return N;

            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Error:" + oe.Message);
                Console.WriteLine("Try Again!!!:");

                return ReadNumber(start, end);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
                return int.MinValue;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Console.WriteLine("Try Again!!!:");

                return ReadNumber(start, end);

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number:" + fe.Message);
                Console.WriteLine("Try Again!!!:");

                return ReadNumber(start, end);
            }
            
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            numbers[0] = ReadNumber(0, 100);
            for (int i = 1; i < 10; i++)
            {
                if (numbers[i - 1] == int.MinValue)
                {
                    numbers[i] = int.MinValue;
                }
                else
                {
                    numbers[i] = ReadNumber(numbers[i - 1], 100);
                }

            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
