using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_Operator_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i=0;i<10;i++)
            {
                if (i == 5)
                {
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine("i: " + i);
            }
            for (int i=0;i<10;i++)
            {
                if (i%2 == 1)
                {
                    continue;
                }
                total += i;
                Console.WriteLine("total: " + total);
            }
            Console.WriteLine("total result: " + total);
        }
    }
}
