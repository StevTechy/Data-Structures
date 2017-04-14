using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Testing
{
    public class Tester
    {
        public void TestQueue()
        {
            var queue = new Queue();

            Console.WriteLine($"Adding item: {1}");
            queue.Add(1);
            Console.WriteLine($"Adding item: {3}");
            queue.Add(3);
            Console.WriteLine($"Adding item: {4}"); ;
            queue.Add(4);

            Console.WriteLine($"Peeking... {queue.Peek()}");

            Console.WriteLine($"Adding item: {5}");
            queue.Add(5);

            Console.WriteLine($"Removed {queue.Remove()}");

            Console.WriteLine($"Peeking... {queue.Peek()}");
        }

        public void TestStack()
        {
            var stack = new Stack();

            Console.WriteLine($"Adding item: {1}");
            stack.Push(1);
            Console.WriteLine($"Adding item: {3}");
            stack.Push(3);
            Console.WriteLine($"Adding item: {4}"); ;
            stack.Push(4);

            Console.WriteLine($"Peeking... {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Peeking... {stack.Peek()}");

            stack.Pop();

            Console.WriteLine($"Peeking... {stack.Peek()}");
        }
    }
}
