using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Task1
{
    internal class LinkedListDemo
    {
        static void Main()
        {
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");//added to first index
            Queue<int> list = new Queue<int>();

            PriorityQueue<int, int> queue = new System.Collections.Generic.PriorityQueue<int, int>();
            queue.Enqueue(10, 10);
            queue.Enqueue(20, 20);
            queue.Enqueue(30, 3);


            //queue.Dequeue();

            while (queue.Count > 0)
            {
                var element = queue.Dequeue();
                Console.WriteLine("Executing task: {0}", element);
            }
        }
    }
}
