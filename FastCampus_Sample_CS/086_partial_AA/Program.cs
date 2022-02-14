using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _086_partial_AA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.SetNum(10);
            aa.ADD();

            aa.SetNum(200);
            aa.MUL();
        }
    }
}
