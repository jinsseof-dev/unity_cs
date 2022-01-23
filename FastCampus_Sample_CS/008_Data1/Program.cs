using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Data1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 120;
            byte b = 255;
            short c = 30000;
            long d = 1000000000000000000;
            ulong f = 10000000000000000000;
            int num = 100;

            Console.WriteLine("sbyte a : {0}", a);
            Console.WriteLine("byte b  : {0}", b);
            Console.WriteLine("short c : {0}", c);
            Console.WriteLine("long d  : {0}", d);
            Console.WriteLine("ulong f : {0}", f);
            Console.WriteLine("int num : {0}", num);

            Console.ReadKey();
        }
    }
}
