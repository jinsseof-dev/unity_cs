using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_Date_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141593f;
            decimal c = 3.141592653589732384626433832m;

            string strA = a.ToString();
            string strB = b.ToString();
            string strC = c.ToString();

            Console.WriteLine("a.ToString(): {0}\n a.ToString().GetType(): {1}", strA, strA.GetType());
            Console.WriteLine("b.ToString(): {0}\n b.ToString().GetType(): {1}", strB, strB.GetType());
            Console.WriteLine("c.ToString(): {0}\n c.ToString().GetType(): {1}", strC, strC.GetType());
        }
    }
}
