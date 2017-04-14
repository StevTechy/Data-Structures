using System;

namespace Data_Structures.Testing
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}
