using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation.DriverProgramClasses
{
    public class DriverMenuOutput
    {
        internal static void PrintMenu(Stack stack)
        {
            Console.WriteLine("A - Add to Stack, D - Delete from Stack, P - Print Stack, E - Exit");
            DriverMenuInput.Select(stack);
        }
    }
}
