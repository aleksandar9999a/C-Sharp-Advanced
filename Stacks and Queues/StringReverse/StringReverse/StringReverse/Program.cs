using System;
using System.Linq;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Reverse().ToList().ForEach(Console.Write);
        }
    }
}
