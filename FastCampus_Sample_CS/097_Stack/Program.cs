using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _097_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("stack data Peek: {0}", stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("stack data: {0}, count: {1}", stack.Pop(), stack.Count);
            }

            // 배열 데이터로 초기화
            Console.WriteLine("배열 데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Stack stackCopy = new Stack(arrData);
            
            foreach(object data in stackCopy)
            {
                Console.WriteLine("stackCopy data: {0}", data);
            }
        }
    }
}
