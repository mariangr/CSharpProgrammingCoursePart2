using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._08_AddTwoDigits
{
    class Program
    {
        static int[] Sum(string first, string second)
        {
            
            int theBiggerSize = Math.Max(first.Length, second.Length);

            int[] result = new int[theBiggerSize+1];

            int[] firstNumber = new int[first.Length];
            int[] secondNumber = new int[second.Length];

            for (int i = 0; i < first.Length; i++)
            {
                firstNumber[i] = first[i] - '0';
            }

            for (int i = 0; i < second.Length; i++)
            {
                secondNumber[i] = second[i] - '0';
            }

            bool naum = false;

            for (int i = firstNumber.Length - 1, j = secondNumber.Length - 1, k = result.Length - 1; (i >= -1 || j >= -1) && k>=0 ; i--, j--, k--)
            {
                if (i < 0 && j < 0)
                {
                    if (naum)
                    {
                        result[k] = 1;
                    }
                }
                else if(i<0 && j>=0)
                {
                    if (naum)
                    {
                        if (secondNumber[j] + 1 > 9)
                        {
                            result[j+1] = (secondNumber[j] + 1)%10;
                            naum = true;
                        }
                        else
                        {
                            result[j+1] = secondNumber[j] + 1;
                            naum = false;
                        }
                    }
                    else
                    {
                        result[j+1] = secondNumber[j];
                    }
                }
                else if (j < 0 && i>=0)
                {
                    if (naum)
                    {
                        if (firstNumber[i] + 1 > 9)
                        {
                            result[i+1] = (firstNumber[i] + 1) % 10;
                            naum = true;
                        }
                        else
                        {
                            result[i+1] = firstNumber[i] + 1;
                            naum = false;
                        }
                    }
                    else
                    {
                        result[i+1] = firstNumber[i];
                    }
                }
                else if (naum)
                {
                    if (firstNumber[i] + secondNumber[j] + 1 > 9)
                    {
                        result[k] = (firstNumber[i] + secondNumber[j] + 1) % 10;
                        naum = true;
                    }
                    else
                    {
                        result[k] = firstNumber[i] + secondNumber[j] + 1;
                        naum = false;
                    }
                }
                else 
                {
                    if (firstNumber[i] + secondNumber[j] > 9)
                    {
                        result[k] = (firstNumber[i] + secondNumber[j]) % 10;
                        naum = true;
                    }
                    else
                    {
                        result[k] = firstNumber[i] + secondNumber[j];
                        naum = false;
                    }
                }
            }

            return result;
        }

        static void PrintResult(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 && array[i] == 0)
                {
                    continue;
                }
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            string first = Console.ReadLine();
            Console.Write("Enter Second Number: ");
            string second = Console.ReadLine();

            PrintResult(Sum(first, second));
        }
    }
}
