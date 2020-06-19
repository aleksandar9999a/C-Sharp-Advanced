using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ');
            var toss = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(names);

            while(queue.Count > 1)
            {
               for(var i = 1; i < toss; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
