using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation.DriverProgramClasses
{
    public class DriverMenuOutput
    {
        internal static void PrintMenu(Queue queue)
        {
            Console.WriteLine("A - Add to queue, D - Delete from queue, P - Print Queue, E - Exit");
            DriverMenuInput.Select(queue);
        }
    }
}
