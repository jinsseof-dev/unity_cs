using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Data_object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = 100;
            object b = 3.14159123123123123f;
            object c = 3.14159123123123123m;
            object d = 'H';
            object e = "World!";
            object f = false;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);
            Console.WriteLine("d: {0}", d);
            Console.WriteLine("e: {0}", e);
            Console.WriteLine("f: {0}", f);
        }
    }
}
