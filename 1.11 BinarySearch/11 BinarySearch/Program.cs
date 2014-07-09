using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 25, 68, 100, 120, 130, 300 };
            int start = 0, end = array.Length;
           
            int middle = (end - start) / 2;
            bool found = false;
            int element = 7;
            int? index = null;
            while (!found)
            {
                if (element == array[middle])
                {
                    index = middle;
                    found = true;

                }
                else 
                {
                    
                    if (element < array[middle])
                    {
                        end = middle;
                        middle = start + (end - start) / 2;
                        
                    }
                    if (element > array[middle])
                    {
                        start = middle;
                        middle = start + (end - start) / 2;
                    }
                }
            }
            Console.WriteLine(index);

        }
    }
}
