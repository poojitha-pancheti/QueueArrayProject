using System;
using System.Collections.Generic;
using System.Text;

namespace QueueArrayProject
{
    class Demo
    {
        static void Main(string[] args)
        {

            int choice, x;
            QueueA qu = new QueueA(8);
            while (true)
            {
                Console.WriteLine("1.Insert an element in the queue");
                Console.WriteLine("2.Delete an element from queue");
                Console.WriteLine("3.Delete eement from top");
                Console.WriteLine("4.Delete all elements from queue");
                Console.WriteLine("5.Display the size of queue");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));
                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to be inserted:");
                        x = Convert.ToInt32(Console.ReadLine());
                        qu.Insert(x);
                        break;
                    case 2:
                        x = qu.Delete();
                        Console.WriteLine("Element deleted is:" + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the front is:" + qu.peek());
                        break;
                    case 4:
                        qu.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of the queue:"+qu.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;


                }
                Console.WriteLine(" ");
            }
        }
    }
}
