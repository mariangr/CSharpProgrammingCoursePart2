using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._05_TagsToUpperString
{
    class Program
    {
        static bool checkIfTagsAreCorrect(string text, string startTag, string endTag)
        {
            Stack<int> br = new Stack<int>();

            for (int i = 0; i < text.Length - endTag.Length; i++)
            {
                if ((text.Substring(i, startTag.Length)) == (startTag))
                {
                    if (br.Count != 0)
                    {
                        return false;
                    }
                    br.Push(1);
                }
                if ((text.Substring(i, endTag.Length)) == (endTag))
                {
                    if (br.Count == 0)
                    {
                        return false;
                    }
                    br.Pop();
                }
            }

            if (br.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int[] startIndexes(string text, string startTag)
        { 
            List<int> result = new List<int>();
            int index = -1;
            while (true)
            {
                index = text.IndexOf(startTag, index + 1);
                if (index == -1)
                {
                    break;
                }
                result.Add(index + startTag.Length);
            }
            return result.ToArray();
        }

        static int[] endIndexes(string text, string endTag)
        {
            List<int> result = new List<int>();
            int index = -1;
            while (true)
            {
                index = text.IndexOf(endTag, index + 1);
                if (index == -1)
                {
                    break;
                }
                result.Add(index -1);
            }
            return result.ToArray();
        }


        static string newUppercasedText(string text, string startTag, string endTag)
        {
            int j = 0;
            int[] startIndex = startIndexes(text, startTag);
            int[] endIndex = endIndexes(text, endTag);

            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (i - 1 == endIndex[j] && j <startIndex.Length - 1)
                {
                    j++;
                }
                if (i >= startIndex[j] && i <= endIndex[j])
                {
                    newString.Append(text[i].ToString().ToUpper());
                }
                else
                {
                    newString.Append(text[i]);
                }
            }
            newString.Replace(startTag, "");
            newString.Replace(endTag, "");


            return newString.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Write text: ");
            string text = Console.ReadLine();

            string startTag = "<upcase>";
            string endTag = "</upcase>";

            if (checkIfTagsAreCorrect(text, startTag, endTag))
            {
                string result = newUppercasedText(text, startTag, endTag);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The tags are not correct");
            }
        }
    }
}
