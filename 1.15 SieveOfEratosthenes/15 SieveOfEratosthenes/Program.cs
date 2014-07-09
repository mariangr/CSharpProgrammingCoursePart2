using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<int> primeNumbers = new List<int>();
        primeNumbers.Add(2);

        for (int i = 3; i <= 10000000; i++)
        {
            int br = 0;
            int brAll = 0;
            for (int j = 0; j < primeNumbers.Count && primeNumbers[j]<Math.Sqrt(i); j++)
            {
                brAll++;
                if (i % primeNumbers[j] != 0)
                {
                    br++;
                }
            }
            if (br == brAll)
            {
                primeNumbers.Add(i);
            }
        }

        for (int j = 0; j < primeNumbers.Count; j++)
        {
            Console.Write(primeNumbers[j] + " ");
        }

    }
}
