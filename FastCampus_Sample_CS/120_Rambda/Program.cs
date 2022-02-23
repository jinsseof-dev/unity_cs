using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120_Rambda
{
    delegate void dPrint(string str);
    delegate int dAdd(int a);
    internal class Program
    {
        static public void CallPrint(string str)
        {
            Console.WriteLine(str);
        }
        static public int CallAdd(int a)
        {
            return a + a;
        }
        static void Main(string[] args)
        {
            dPrint dp = CallPrint;
            dp("CallPrint");
            dp = (str) => { Console.WriteLine(str); };
            dp("Rambda");

            dAdd da = CallAdd;
            Console.WriteLine("CallAdd: " + da(11));
            da = (a) => { return a + a; };
            Console.WriteLine("Rambda: " + da(222));
        }
    }
}
