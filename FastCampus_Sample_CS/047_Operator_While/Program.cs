﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_Operator_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int total = 0;
            int total2 = 0;

            while(a <= 10 || b <= 10)
            {
                total = total + a++;
                total2 = total2 + ++b;
            }

            Console.WriteLine("total: {0}", total);
            Console.WriteLine("total2: {0}", total2);
        }
    }
}
