﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World!";
            string str3 = str1 + str2;
            Console.WriteLine(str3);

            string str4 = "zzz";
            string str5 = "zzz";
            string str6 = "zzzz";
            Console.WriteLine("{0} == {1}: {2}", str4, str5, (str4 == str5));
            Console.WriteLine("{0} == {1}: {2}", str4, str6, (str4 == str6));
            Console.WriteLine("{0} != {1}: {2}", str4, str5, (str4 != str5));
            Console.WriteLine("{0} != {1}: {2}", str4, str6, (str4 != str6));


            string str7 = "Hello World!";
            string str8 = str7.Replace("Hello", "Hi");
            Console.WriteLine("str8: {0}", str8);

            Console.WriteLine("str8.ToUpper(): {0}", str8.ToUpper());
            Console.WriteLine("str8.ToLower(): {0}", str8.ToLower());
        }
    }
}
