using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            result.Add(10);
            result.Add(10); result.Add(10); result.Add(10); result.Add(10); result.Add(10); result.Add(10); result.Add(10); result.Add(10);
            result.RemoveAt(0); result.RemoveAt(0); result.RemoveAt(0); result.RemoveAt(0); result.RemoveAt(0); result.RemoveAt(0); result.RemoveAt(0); result.RemoveAt(0); result.RemoveAt(0);

            Console.WriteLine(result.Count);
        }
    }
}
