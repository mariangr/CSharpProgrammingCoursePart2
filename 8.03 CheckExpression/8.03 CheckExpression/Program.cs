using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._03_CheckExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write expression: ");
            string expression = Console.ReadLine();
            Stack<int> br = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    br.Push(1);
                }
                if (expression[i] == ')')
                {
                    if (br.Count == 0)
                    {
                        br.Push(1);
                        break;
                    }
                    br.Pop();
                }
            }

            if (br.Count != 0)
            {
                Console.WriteLine("The expression is not correct.");
            }
            else
            {
                Console.WriteLine("The expression is correct.");                
            }
        }
    }
}
