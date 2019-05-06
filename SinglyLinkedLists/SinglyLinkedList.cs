using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        public void AddFirst(int value)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode();
            new_node.value = value;

            if (head == null)
            {
                head = new_node;
            }

            else
            {
                new_node.next = head;
                head = new_node;
            }
        }

        public void AddLast(int value)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode();
            new_node.value = value;

            if (head == null)
            {
                head = new_node;
            }

            else
            {
                SinglyLinkedListNode dummy_node = head;
                while (dummy_node.next != null)
                {
                    dummy_node = dummy_node.next;
                }

                dummy_node.next = new_node;
            }
        }

        public void InsertBefore(int value, int key)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode();
            new_node.value = value;

            try
            {
                if (head == null)
                {
                    head = new_node;
                }

                else
                {
                    SinglyLinkedListNode dummyNode = head;

                    if (dummyNode.next == null || key == head.value)
                    {
                        new_node.next = head;
                        head = new_node;
                    }

                    else
                    {
                        while (dummyNode.next.value != key && dummyNode.next != null)
                        {
                            dummyNode = dummyNode.next;
                        }

                        new_node.next = dummyNode.next;
                        dummyNode.next = new_node;
                    }
                }
            }

            catch
            {
                AddFirst(value);        // if no key is found, the element will be inserted first
            }
        }

        public void InsertAfter(int value, int key)
        {
            SinglyLinkedListNode new_node = new SinglyLinkedListNode();
            new_node.value = value;

            if (head == null)
            {
                head = new_node;
            }

            else
            {
                SinglyLinkedListNode dummyNode = head;
                try
                {
                    while (dummyNode.value != key)
                    {
                        dummyNode = dummyNode.next;
                    }
                    new_node.next = dummyNode.next;
                    dummyNode.next = new_node;
                }

                catch
                {
                    AddLast(value);     // if no value is found, the element will be added at the end of the list
                }
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }

            else
            {
                head = head.next;
            }
        }

        public void RemoveLast()
        {
            SinglyLinkedListNode dummyNode = head;

            if (head == null)
            {
                return;
            }

            else
            {
                while (dummyNode.next.next != null)
                {
                    dummyNode = dummyNode.next;
                }

                dummyNode.next = null;
            }
        }

        public SinglyLinkedListNode head = null;
    }
}