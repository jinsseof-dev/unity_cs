using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _079_this_AA
{
    class AA
    {
        private int a;
        public AA(int a)
        {
            this.a = a;
        }
        public void Print()
        {
            int a = 100;
            this.a = 1000;
            Console.WriteLine("a is {0}", a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(10);
            aa.Print();
        }
    }
}
