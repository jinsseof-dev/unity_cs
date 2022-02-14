using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _087_extention
{
    class AA
    {
        public void View(string str)
        {
            Console.WriteLine("PrintAA {0}", str);
        }
    }

    static class Util
    {
        public static void Print(this AA aa, string str)
        {
            aa.View(str);
        }

        public static void Sum(this int a)
        {
            Console.WriteLine("{0} + {1} = {2}", a, a, (a + a));
        }
        public static void Sumf(this float a, float b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            Util.Print(aa, "Hi");
            aa.Print("Hello");

            Util.Sum(10);

            20.Sum();

            30.12f.Sumf(12.123f);
        }
    }
}
