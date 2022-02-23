using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_FuncRambda
{
    delegate void dPrint(string str);
    delegate void dFunc();

    internal class Program
    {
        static public void CallPrint(string str)
        {
            Console.WriteLine(str);
        }
        static public void CallBackFunc(dPrint dp, string msg)
        {
            if (null != dp)
            {
                dp("CallBackFunc: " + msg);
            }
        }
        static void Main(string[] args)
        {
            CallBackFunc(CallPrint, "Hello"); // 함수 연결
            CallBackFunc(delegate(string str) { Console.WriteLine(str); }, "Hello1"); // delegate 직접
            CallBackFunc((string str) => { Console.WriteLine(str); }, "Hello2"); //람다식 형태
            CallBackFunc((str) => Console.WriteLine(str), "Hello3"); // 람다식 기본 형태
            CallBackFunc(str => Console.WriteLine(str), "Hello4"); // 람다식 더 간단한 형태

            dFunc dfunc = () => Console.WriteLine("No Params"); // 파라미터가 없는 경우 반드시 () 사용
        }
    }
}
