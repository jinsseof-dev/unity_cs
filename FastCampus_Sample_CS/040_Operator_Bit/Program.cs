using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Operator_Bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;     // 0000 0000  0000 0000  0000 0000  0000 1111
            int b = 22;     // 0000 0000  0000 0000  0000 0000  0001 0110
            string strA = Convert.ToString(a, 2).PadLeft(32, '0');
            Console.WriteLine("strA: {0}", strA);
            string strB = Convert.ToString(b, 2).PadLeft(32, '0');
            Console.WriteLine("strB: {0}", strB);


                            // 0000 0000  0000 0000  0000 0000  0000 1111
                            // 0000 0000  0000 0000  0000 0000  0001 0110
            int c = a & b;  // 0000 0000  0000 0000  0000 0000  0000 0110 => 6
            Console.WriteLine("{0} & {1}: {2}", a, b, c);

                            // 0000 0000  0000 0000  0000 0000  0000 1111
                            // 0000 0000  0000 0000  0000 0000  0001 0110
            int d = a | b;  // 0000 0000  0000 0000  0000 0000  0001 1111 => 31
            Console.WriteLine("{0} | {1}: {2}", a, b, d);

                            // 0000 0000  0000 0000  0000 0000  0000 1111
                            // 0000 0000  0000 0000  0000 0000  0001 0110
            int e = a ^ b;  // 0000 0000  0000 0000  0000 0000  0001 1001 => 25
            Console.WriteLine("{0} ^ {1}: {2}", a, b, e);

                            // 0000 0000  0000 0000  0000 0000  0000 1111
            int f = a << 2; // 0000 0000  0000 0000  0000 0000  0011 1100 => 60
            Console.WriteLine("{0} << 2: {1}", a, f);
            Console.WriteLine("{0} << 1: {1}", a, (a << 1));

                            // 0000 0000  0000 0000  0000 0000  0000 1111
            int g = a >> 2; // 0000 0000  0000 0000  0000 0000  0000 0011 => 3
            Console.WriteLine("{0} >> 2: {1}", a, g);
            Console.WriteLine("{0} >> 1: {1}", a, (a >> 1));

                            // 0000 0000  0000 0000  0000 0000  0001 0110
            int h = ~b;     // 1111 1111  1111 1111  1111 1111  1110 1001 => -23
            Console.WriteLine("~{0}: {1}", a, h);

                            // 0000 0000  0000 0000  0000 0000  0001 0110
            int i = ~b;     // 1111 1111  1111 1111  1111 1111  1110 1001 => -23
            i = i >> 2;     // 1111 1111  1111 1111  1111 1111  1111 1010 => -6 (CPU에 따라 다른 결과)
            Console.WriteLine("~{0} >> 2: {1}", a, i);

        }
    }
}
