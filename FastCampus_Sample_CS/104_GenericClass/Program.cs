using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_GenericClass
{
    class GenericAA<T>
    {
        private T num;

        public T GetNum()
        {
            return num;
        }
        public void SetNum(T data)
        {
            num = data;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericAA<int> AA = new GenericAA<int>();
            AA.SetNum(100);
            Console.WriteLine("AA: {0}", AA.GetNum());

            GenericAA<float> BB = new GenericAA<float>();
            BB.SetNum(20.354f);
            Console.WriteLine("BB: {0}", BB.GetNum());

            GenericAA<string> CC = new GenericAA<string>();
            CC.SetNum("Hello Generic");
            Console.WriteLine("CC: {0}", CC.GetNum());
        }
    }
}
