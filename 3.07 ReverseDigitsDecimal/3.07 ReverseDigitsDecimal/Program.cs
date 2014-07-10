using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._07_ReverseDigitsDecimal
{
    class Program
    {
        static decimal Reverse(string number)
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

            return result;
        }




        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            String number = Console.ReadLine().Replace(".","");

            decimal result = Reverse(number);

            Console.WriteLine(result);

        }
    }
}
