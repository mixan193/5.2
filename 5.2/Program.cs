using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReversWords(Console.ReadLine()));
            Console.ReadKey();
        }
        private static string[] SplitText(string text)
        {
            return text.Split(' ');
        }
        private static string ReversWords(string inputPhrase)
        {
            string[] splitedText = SplitText(inputPhrase);
            string result = "";
            for(int i = splitedText.Length - 1; i >= 0; i--)
            {
                result += splitedText[i] + ' ';
            }
            return result;
        }
    }
}
