using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Data_cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double dNum = (double)num;
            Console.WriteLine("num: {0}, dNum: {1}", num, dNum);

            double dNum1 = 123452678901;
            int num1 = (int)dNum1;
            Console.WriteLine("dNum1: {0}, num1: {1}", dNum1, num1);
        }
    }
}
