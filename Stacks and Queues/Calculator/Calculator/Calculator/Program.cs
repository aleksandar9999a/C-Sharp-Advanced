using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").Reverse();
            var result = new Stack<string>(input);
            
            while (result.Count > 1)
            {
                var firstNumber = int.Parse(result.Pop());
                var op = result.Pop();
                var secondNumber = int.Parse(result.Pop());

                var sum = op switch
                {
                    "+" => (firstNumber + secondNumber),
                    "-" => (firstNumber - secondNumber),
                    _ => 0
                };
                result.Push(sum.ToString());
            }

            Console.WriteLine(result.Pop());
        }
    }
}
