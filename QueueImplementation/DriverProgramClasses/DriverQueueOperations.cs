using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation.DriverProgramClasses
{
    public class DriverQueueOperations
    {
        internal static void Add(Queue queue)
        {
            Console.Write("Element to add: ");
            queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"{queue.First.Value} has been added to the queue...", ConsoleColor.Green);
        }
        internal static void Remove(Queue queue)
        {
            try
            {
                Console.WriteLine($"{queue.First.Value} has been removed from the queue...", ConsoleColor.Red);
                queue.Dequeue();
            }

            catch
            {
                Console.WriteLine($"The queue is empty", ConsoleColor.Red);
            }
        }

        internal static void Print(Queue queue)
        {
            if (queue.First != null)
            {
               Console.Write("Elements in queue: ");
               queue.Print();
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("There are no elements in the current list!", ConsoleColor.Magenta);
            }
        }
    }
}
