using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation.DriverProgramClasses
{
    public class DriverStackOperations
    {
        internal static void Add(Stack stack)
        {
            Console.Write("Value to add: ");
            stack.Push(Convert.ToInt32(Console.ReadLine()));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{stack.Top.Value} has been added to the top of the stack...");
            Console.ResetColor();
        }
        internal static void Remove(Stack stack)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{stack.Top.Value} has been removed from the top of the stack...");
                stack.Pop();
                Console.ResetColor();
            }

            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The stack is empty");
                Console.ResetColor();
            }
        }

        internal static void Print(Stack stack)
        {
            if (stack.Top != null)
            {
                Console.Write("Elements in stack: ");
                stack.Print();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("There are no elements in the current stack!");
                Console.ResetColor();
            }
        }
    }
}
