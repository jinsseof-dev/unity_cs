using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Data4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0b11111111; // 2진수 리터럴 접두사(0b)
            int f = 0xFF;       // 16진수 리터럴 접두사(0x)
            int num = 255;

            Console.WriteLine("a : {0}", a);
            Console.WriteLine("f : {0}", f);
            Console.WriteLine("num : {0}", num);
        }
    }
}
