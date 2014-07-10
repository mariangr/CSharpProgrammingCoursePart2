using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        float number = float.Parse(Console.ReadLine());

        string integer = Convert.ToString(Math.Abs((int)number), 2);
        string fraction = ConvertFractionToBinary(Math.Abs(number - (int)number));

        Console.Write("sign = {0}, ", number < 0 ? 1 : 0);
        Console.Write("exponent = {0}, ", FindExponent(integer, fraction));
        Console.WriteLine("mantisa = {0}", FindMantisa(integer, fraction));
    }

    static string ConvertFractionToBinary(float fraction)
    {
        string binary = null;

        while (fraction != 0)
        {
            fraction *= 2;
            binary += (int)fraction;
            fraction -= (int)fraction;
        }
        return binary;
    }

    static string FindExponent(string integer, string fraction)
    {
        int exponent;

        if (integer.Length != 0)
        {
            exponent = integer.Length - 1;
        }
        else
        {
            exponent = -fraction.IndexOf('1') - 1;
        }

        return Convert.ToString((127 + exponent), 2).PadLeft(8, '0');
    }
    static string FindMantisa(string integer, string fraction)
    {
        string mantisa;

        if (integer.Length != 0)
        {
            mantisa = integer.Substring(1) + fraction;
        }
        else
        {
            mantisa = fraction.Substring(fraction.IndexOf('1') + 1);
        }

        return mantisa.PadRight(23, '0');
    }

}