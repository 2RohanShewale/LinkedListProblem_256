using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            while (true)
            {
                Console.WriteLine("*------Linked List------*");
                Console.WriteLine("\nOptions: ");
                Console.Write("1.Add elements\n2.Display\n3.Add in Reverse \n4.Append \nEnter a number: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.AddReverse(56);
                        linkedList.AddReverse(30);
                        linkedList.AddReverse(70);
                        break;
                    case 4:
                        linkedList.Append(56);
                        linkedList.Append(30);
                        linkedList.Append(70);
                        break;
                    default:
                        Console.WriteLine("type correct value");
                        break;
                }

            }
        }
    }
}
