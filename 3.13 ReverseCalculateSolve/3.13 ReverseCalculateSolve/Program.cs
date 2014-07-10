using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13_ReverseCalculateSolve
{
    class Program
    {
        static void Reverse()
        {
            Console.Write("Enter a non negative number");
            String number = Console.ReadLine().Replace(".", "");
            if (number[0] == '-')
            {
                throw new ArgumentException("It's not non negative.");
            }
            else
            {
                decimal result;
                char[] singleNumbers;
                string reverseNumber = "";
                number.Trim();
                singleNumbers = number.ToCharArray();

                for (int i = singleNumbers.Length - 1; i >= 0; i--)
                {
                    reverseNumber += singleNumbers[i].ToString();
                }
                result = decimal.Parse(reverseNumber);

                Console.WriteLine(result);
            }
        }

        static void ReadAverageInput()
        {
            Console.WriteLine("Enter non-empty sequence of elements separated by comma: ");

            int[] sequence = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

            if (sequence.Length == 0)
            {
                throw new ArgumentException("I said non-empty !!!");
            }
            else
            {
                int result = 0;

                for (int i = 0; i < sequence.Length; i++)
                {
                    result += sequence[i];
                }

                Console.WriteLine(result / sequence.Length);
            }
        }

        static void ReadEquasionInput()
        {
            Console.WriteLine("Enter coefficients (a must not be 0):");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                throw new ArgumentException("a must not be 0 !");
            }

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine((double)-b / a);
        }



        static void Main(string[] args)
        {

            Console.WriteLine("Select action:");
            Console.WriteLine("1 - Reverse digits");
            Console.WriteLine("2 - Calculate the average of a sequence");
            Console.WriteLine("3 - Solve linear equasion");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Reverse();
                    break;
                case 2:
                    ReadAverageInput();
                    break;
                case 3:
                    ReadEquasionInput();
                    break;
                default:
                    break;
            }



        }
    }
}
