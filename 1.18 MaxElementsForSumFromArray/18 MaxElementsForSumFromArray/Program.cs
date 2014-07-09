using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_MaxElementsForSumFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            List<int> maxList = new List<int>();
            int maxSize = 0;
            int variation = (int)Math.Pow(2, array.Length) - 1;

            for (int i = variation; i > 0; i--)
            {
                string binaryI = Convert.ToString(i, 2).PadLeft(array.Length, '0');
                
                bool areAscending = true;
                List<int> numbers = new List<int>();

                for (int j = 0; j < array.Length; j++)
                {

                    if (binaryI[j] == '1')
                    {
                        numbers.Add(array[j]);
                    }
                }

                int br = 0;

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        areAscending = false;
                    }
                    else
                    {
                        br++;
                    }
                }

                if (areAscending && (br > maxSize))
                {
                    maxList = numbers.ToList();
                    maxSize = br;
                }


                numbers.RemoveRange(0, numbers.Count);

            }

            for (int j = 0; j < maxList.Count; j++)
            {
                Console.Write(maxList[j] + " ");
            }
            Console.WriteLine("");
        }
    }
}

