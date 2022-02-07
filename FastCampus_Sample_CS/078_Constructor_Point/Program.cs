using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078_Constructor_Point
{
    public class Point
    {
        private int a;

        public Point(int _a)
        {
            a = _a;
            Console.WriteLine("Constructor is Called!!");
            Console.WriteLine("attribute a is {0}", a);
        }
        ~Point()
        {
            a = 0;
            Console.WriteLine("Destructor is Called!!");
            Console.WriteLine("attribute a is {0}", a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 101;
            Point point = new Point(a);

        }
    }
}
