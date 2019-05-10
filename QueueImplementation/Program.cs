using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueImplementation.DriverProgramClasses;

namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a driver program to test the functionality of the queue");
            Queue queue = new Queue();
            DriverMenuOutput.PrintMenu(queue);
        }
    }
}
