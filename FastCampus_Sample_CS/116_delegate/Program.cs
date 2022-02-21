using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _116_delegate
{
    delegate int DelegateFunc(int a);
    internal class Program
    {
        static int Add(int a)
        {
            Console.WriteLine("Add");
            return a + a;
        }
        static void Main(string[] args)
        {
            DelegateFunc delegateFunc = Add; // delegateFunc가 Add의 역할을 할 수 있음
            Console.WriteLine("delegateFunc: {0}", delegateFunc(10));
        }
    }
}
