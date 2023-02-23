using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        public void AddReverse(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                node.next = temp;
                head = node;
            }
            Console.WriteLine($"{node.data} is now Head");
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head != null)
            {
                Node temp = head;
                while (temp.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine($"{node.data} is added after {temp.data}");
            }
            else { head = node; }
        }
        public void InsertInPosition(int position , int data)
        {

            if (head != null && position >0)//
            {
                Node node = new Node(data);
                if (position == 1)
                {
                    node.next = head;
                    this.head = node;
                }
                else 
                {
                    Node temp = head;
                    for (int i = 1; i < position-1; i++)
                    {
                        if (temp.next == null)
                        {
                            Console.WriteLine("Entered position is larger than linkedlists length\n Adding data at the last node.next");
                            break;
                        }
                        temp= temp.next;
                    }
                    node.next = temp.next;//null
                    temp.next=node;
                }
                Display();
            }
            else
            {
                Console.WriteLine("Enter Valid Position");
            }
            

        }
    }
}
