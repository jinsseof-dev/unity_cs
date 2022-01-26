using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Data_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var b = 3.14159123123123123f;
            var c = 3.14159123123123123m;
            var d = 'H';
            var e = "World!";
            var f = false;

            Console.WriteLine("type: {0}, a: {1}", a.GetType(), a);
            Console.WriteLine("type: {0}, b: {1}", b.GetType(), b);
            Console.WriteLine("type: {0}, c: {1}", c.GetType(), c);
            Console.WriteLine("type: {0}, d: {1}", d.GetType(), d);
            Console.WriteLine("type: {0}, e: {1}", e.GetType(), e);
            Console.WriteLine("type: {0}, f: {1}", f.GetType(), f);

            // var noInitalVar;

            var num = 0;
            num = 100;

            Console.WriteLine("num: " + num);
        }
    }
}
