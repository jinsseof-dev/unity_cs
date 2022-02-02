using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _064_Func_default
{
    internal class Program
    {
        static void PrintValue(int a, int b, int c=100, int d=200)
        {
            Console.WriteLine("PrintValue: {0}, {1}, {2}, {3}", a, b, c, d);
        }
        static void Main(string[] args)
        {
            PrintValue(11, 12, 13, 14);
            PrintValue(21, 22, 23);
            PrintValue(31, 32);
        }
    }
}
