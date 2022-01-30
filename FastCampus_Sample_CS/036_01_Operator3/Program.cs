using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_01_Operator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 100;

            a += b; // a = 
            Console.WriteLine("a: " + a);

            a -= b; // a = a - b
            Console.WriteLine("a: " + a);

            a *= b; // a = a * b
            Console.WriteLine("a: " + a);

            a /= 10; // a = a / b
            Console.WriteLine("a: " + a);

            a %= 10; // a = a % b
            Console.WriteLine("a: " + a);
        }
    }
}
