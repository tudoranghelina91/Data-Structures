using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();

            // add node first;
            list.AddFirst(2);
            list.AddFirst(1);

            // add node last
            list.AddLast(4);
            list.AddLast(6);

            // add node before
            list.InsertBefore(0, 1);

            // add node after
            list.InsertAfter(5, 4);

            // print before removal
            SinglyLinkedListNode node = list.head;  // create node and assign to head of list
            while (node != null)
            {
                Console.Write("{0} ", node.value);
                node = node.next;
            }

            Console.WriteLine();

            // remove first
            list.RemoveFirst();
            list.RemoveLast();

            // print before removal
            node = list.head;  // create node and assign to head of list
            while (node != null)
            {
                Console.Write("{0} ", node.value);
                node = node.next;
            }

            Console.ReadKey();
        }
    }
}
