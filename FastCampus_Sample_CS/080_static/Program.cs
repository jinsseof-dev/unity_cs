using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080_static
{
    internal class Program
    {
        class AA
        {
            public static int a;
            public static int b;
            public static readonly int c = 200; // readonly는 읽기 전용 속성을 부여

            public static void Print()
            {
                Console.WriteLine("a is {0}", a);
                Console.WriteLine("b is {0}", b);
            }
        }

        class BB
        {
            public int c;
            public int d;

            public void Print()
            {
                Console.WriteLine("c is {0}", c);
                Console.WriteLine("d is {0}", d);
            }
        }
        static void Main(string[] args)
        {
            AA.a = 10;
            AA.b = 100;
            AA.Print();

            BB bb = new BB();
            bb.c = 10;
            bb.d = 100;
            bb.Print();

            //BB.c = 10;
            //BB.b = 100;
            //BB.Print();
        }
    }
}
