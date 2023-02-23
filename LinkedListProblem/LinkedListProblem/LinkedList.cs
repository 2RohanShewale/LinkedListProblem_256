using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"\n{node.data} is added to the list.");
        }

        public void Display()
        {
            Node temp= this.head;
            if (head != null)
            {
                Console.WriteLine("\nItems in list are: ");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp= temp.next;
                }
            }
        }
    }
}
