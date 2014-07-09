using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4, 1, 1, 4, 2, 4, 3, 4, 4, 1, 2, 4, 9, 3} ;
            
            int mostFrequentNumber = array[0];
            int brF = 0;
            int br = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    if (currentNumber == array[j])
                    {
                        br++;
                    }
                }
                if (br > brF)
                {
                    brF = br;
                    mostFrequentNumber = currentNumber;
                }
                br = 0;

            }
            Console.WriteLine("Most Frequent Number: " + mostFrequentNumber);
        }
    }
}
