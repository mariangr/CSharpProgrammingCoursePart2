using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        public static void QuickSort(int[] a, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = a[(left + right) / 2];
            while (i <= j)
            {
                while (a[i] < pivot)
                    i++;
                while (a[j] > pivot)
                    j--;
                if (i <= j)
                {
                    int tmp = a[i];
                    a[i++] = a[j];
                    a[j--] = tmp;
                }
            }
            if (j > left)
            {
                QuickSort(a, left, j);
            }
            if (i < right)
            {
                QuickSort(a, i, right);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            QuickSort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
