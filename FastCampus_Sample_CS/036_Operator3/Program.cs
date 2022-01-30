using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Operator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine("num: {0}", num++);
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", ++num);

            Console.WriteLine("num: {0}", num--);
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("num: {0}", --num);
        }
    }
}
