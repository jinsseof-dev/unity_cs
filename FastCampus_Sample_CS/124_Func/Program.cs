using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_Func
{
    internal class Program
    {
        static int CallFunc()
        {
            return 100;
        }
        static void Main(string[] args)
        {
            Func<int> aFunc;
            Func<int, float> aFunc2;
            Func<int, int, int> aFunc3;
            int A = 1;
            aFunc = CallFunc;
            aFunc2 = (int a) => { return (float)(a / 2.0f); };
            aFunc3 = (a, b) => (a + b);

            Console.WriteLine("aFunc: {0}", aFunc());
            Console.WriteLine("aFunc2: {0}", aFunc2(10));
            Console.WriteLine("aFunc3: {0}", aFunc3(100, 200));
        }
    }
}
