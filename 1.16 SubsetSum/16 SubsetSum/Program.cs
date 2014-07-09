using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int S = 14;

            int counter = 0;

            int variation = (int)Math.Pow(2, array.Length) - 1;

            for (int i = 1; i <= variation; i++)
            {
                string binaryI = Convert.ToString(i, 2).PadLeft(array.Length, '0');
                long result = 0;
                string strResult = "";

                for (int j = 0; j < array.Length; j++)
                {
                    if (binaryI[j] == '1')
                    {
                        result += array[j];
                        strResult += array[j] + " + ";
                    }
                }

                if (result == S)
                {
                    strResult = strResult.Remove(strResult.Length - 3);
                    Console.WriteLine("yes ({0})", strResult);
                    counter++;
                }
            }
        }
    }

}
 
