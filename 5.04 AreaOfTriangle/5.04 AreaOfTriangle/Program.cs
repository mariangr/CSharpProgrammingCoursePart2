using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._04_AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateByAltitude(1, 2));
            Console.WriteLine(CalculateBySides(3, 2, 4));
            Console.WriteLine(CalculateByAngle(1, 2, 30));
        }

        static double CalculateByAltitude(double a, double h)
        {
            return (a * h) / 2;
        }

        static double CalculateBySides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static double CalculateByAngle(double a, double b, double alpha)
        {
            return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
        }
    }
}