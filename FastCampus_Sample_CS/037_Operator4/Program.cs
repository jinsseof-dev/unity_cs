using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_Operator4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 1000;

            Console.WriteLine("(a == b): {0}", (a == b));
            Console.WriteLine("(a != b): {0}", (a != b));
            Console.WriteLine("(a >  b): {0}", (a >  b));
            Console.WriteLine("(a <  b): {0}", (a <  b));
            Console.WriteLine("(a >= b): {0}", (a >= b));
            Console.WriteLine("(a <= b): {0}", (a <= b));
        }
    }
}
