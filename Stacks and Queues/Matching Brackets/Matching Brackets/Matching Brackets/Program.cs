using System;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    stack.Push(i);
                }
                else if (text[i] == ')')
                {
                    var iOfOpeningBracket = stack.Pop();

                    var result = text.Substring(iOfOpeningBracket, i - iOfOpeningBracket + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
