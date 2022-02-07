using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _077_class_Point
{
    public class Point
    {
        private int a;
        public int b;
        protected int c;

        public int getA()
        {
            return a;
        }
        public bool setA(int _a)
        {
            this.a = _a;
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            bool result = false;
            Point point = new Point();
            result = point.setA(a);
            point.b = b;
            Console.WriteLine("a is {0}", point.getA());
        }
    }
}
