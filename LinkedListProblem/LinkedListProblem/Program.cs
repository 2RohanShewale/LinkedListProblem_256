using System;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            LinkedList linkedList = new LinkedList();
            while (true)
            {
                Console.WriteLine("*------Linked List------*");
                Console.WriteLine("\nOptions: ");
                Console.Write("1.Add elements\n2.Display\n3.Add in Reverse \n4.Append \n5.Isert At a position\n6.Pop('Remove first element')\n7.PopLast('Remove Last Element')\n8.Search an element\nEnter a number: ");
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
                        linkedList.AddReverse(random.Next(1, 999));
                        linkedList.AddReverse(random.Next(1, 999));
                        linkedList.AddReverse(random.Next(1, 999));
                        break;
                    case 4:
                        linkedList.Append(random.Next(1, 999));
                        linkedList.Append(random.Next(1, 999));
                        linkedList.Append(random.Next(1, 999));
                        break;
                    case 5:
                        Console.Write("Enter Data to insert: "); int data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the posititon to insert: "); int position = Convert.ToInt32(Console.ReadLine());
                        linkedList.InsertInPosition(position, data);
                        break;
                    case 6:
                        linkedList.Pop();
                        break;
                    case 7:
                        linkedList.PopLast();
                        break;
                    case 8:
                        linkedList.SearchValue(30);
                        linkedList.SearchValue(1324);
                        break;
                    default:
                        Console.WriteLine("type correct value");
                        break;
                }

            }
        }
    }
}
