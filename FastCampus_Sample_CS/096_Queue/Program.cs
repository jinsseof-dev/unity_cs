using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _096_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("queue data Peek: {0}", queue.Peek());

            while(queue.Count > 0)
            {
                Console.WriteLine("queue data: {0}, count: {1}", queue.Dequeue(), queue.Count);
            }

            // 배열 데이터로 초기화
            Console.WriteLine("배열 데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Queue queueCopy = new Queue(arrData);
        }
    }
}
