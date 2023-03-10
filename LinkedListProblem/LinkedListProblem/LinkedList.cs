using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;

namespace LinkedListProblem
{
    public class LinkedList
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

        public string Display()
        {
            string str = "";
            Node temp = this.head;
            if (head != null)
            {
                Console.WriteLine("\nItems in list are: ");
                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    str += temp.data + "->";
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n>>>>This list is empty");
            }
            return str;
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
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine($"{node.data} is added after {temp.data}");
            }
            else { head = node; }
        }
        public void InsertInPosition(int position, int data)
        {
            if (head != null && position > 0)//
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
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp.next == null)
                        {
                            Console.WriteLine("Entered position is larger than linkedlists length\n Adding data at the last node.next");
                            break;
                        }
                        temp = temp.next;
                    }
                    node.next = temp.next;//null
                    temp.next = node;
                }
                Display();
            }
            else
            {
                Console.WriteLine("\n>>>>Enter Valid Position");
            }

        }
        public void Pop()//
        {
            if (head != null)
            {
                Node temp = head.next;
                head = temp;
                Display();
            }
            else
            {
                Console.WriteLine("\n>>>>Linked list is empty.");
            }

        }
        public void PopLast()
        {
            if (head != null)
            {
                if (head.next == null)
                {
                    head = null;
                }
                else
                {
                    Node temp = head;
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    //temp is second last
                    temp.next = null;
                }
                
            }
            Display();
        }
        public bool SearchValue(int value)
        {
            bool doesExists = false;
            if (head != null)
            { 
                int position = 0;
                Node temp = head;
                while (temp.next != null)
                {
                    if (temp.data == value) { doesExists = true; break; }
                    position++;
                    temp = temp.next;
                }
                if (doesExists) { Console.WriteLine($"{value} exists at {position + 1}th position"); }
                else { Console.WriteLine($"{value} is not present in list"); }
            }Display();
            return doesExists;
        }
        public string InsertValueAfter(int data, int presentData)
        {
            bool doesExists = false;
            Node node = new Node(data);
            if(head != null)
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == presentData)
                    {
                        doesExists = true;
                        break;
                    }
                    temp= temp.next;
                }
                if (doesExists)
                {
                    node.next = temp.next;
                    temp.next = node;
                }
                else { Console.WriteLine($"{presentData} is not in the list"); }
            }
            return Display();
        }
        public string Delete(int data)
        {
            if (head!= null)
            {
                if (head.next == null && head.data == data)//If it only contains head
                    head = null;
                else
                {
                    if (head.data == data)
                    {
                        head = head.next;
                    }
                    else
                    {
                        Node temp = head;
                        while (temp != null)
                        {
                            if (temp.next.data == data) { break; }
                            temp = temp.next;
                        }
                        temp.next = temp.next.next;
                    }
                }
            }
            
            return Display();
        }
    }
}
