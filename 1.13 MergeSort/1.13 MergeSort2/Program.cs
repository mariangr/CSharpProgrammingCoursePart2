using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static List<int> Merge(List<int> first, List<int> second)
    {
        List<int> result = new List<int>();

        while (first.Count > 0 || second.Count > 0)
        {
            if (first.Count == 0)
            {
                while (second.Count > 0)
                {
                    result.Add(second[0]);
                    second.RemoveAt(0);
                }
            }
            else if (second.Count == 0)
            {
                while (first.Count > 0)
                {
                    result.Add(first[0]);
                    first.RemoveAt(0);
                }
            }
            else if (first[0] < second[0])
            {
                result.Add(first[0]);
                first.RemoveAt(0);
            }
            else
            {
                result.Add(second[0]);
                second.RemoveAt(0);
            }
        }
        return result;
    }



    public static List<int> MergeSort(int[] array, int left, int right)
    {
        int middle = (right + left) / 2;
        if (right - left >= 1)
        {
            return Merge(MergeSort(array, left, middle), MergeSort(array, middle + 1, right));
        }
        else
        {
            List<int> res = new List<int>();
            res.Add(array[right]);
            return res;
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int[] newArray = MergeSort(array, 0, array.Length - 1).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(newArray[i] + " ");
        }
    }
}