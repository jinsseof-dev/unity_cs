using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081_class_inheritance_Super
{
    class Super
    {
        private int a;
        protected string b;
        public Super(int _a)
        {
            this.a = _a;
            Console.WriteLine("Super 생성자 호출");
        }
        public void PrintSuper()
        {
            this.b = "smith";
            Console.WriteLine("Super b: {0}", this.b);
        }
    }
    class Sub:Super
    {
        private int b;
        public Sub(int _a, string _b):base(_a)
        {
            Console.WriteLine("Sub 생성자 호출");
        }
        public void PrintSub()
        {
            base.b = "Super";

            Console.WriteLine("Super b: {0}", base.b);
            base.PrintSuper();
            Console.WriteLine("Sub   b: {0}", this.b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string b = "Jack";
            Sub sub = new Sub(a, b);
            sub.PrintSub();
        }
    }
}
