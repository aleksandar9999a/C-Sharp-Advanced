using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static int SomeFunc()
        {
            return 5;
        }
        static void Main(string[] args)
        {
            var myList = new List<string>();
            myList.Add("first");
            myList.Add("second");
            myList.Add("third");

            myList[0] = "Test";

            var myStack = new Stack<string>();
            myStack.Push("first");
            myStack.Push("second");
            myStack.Push("third");

            var res = myStack.Pop();
            var contains = myStack.Contains("third");

            Console.WriteLine(res);
            Console.WriteLine(contains);

            var newRes = myStack.Peek();
            var count = myStack.Count();

            Console.WriteLine(newRes);
            Console.WriteLine(count);

            myStack.Where(x => x == "first").ToList().ForEach(Console.WriteLine);

            foreach(var i in myStack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
