using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_Func_out
{
    internal class Program
    {
        static void initNum(out int addNum)
        {
            addNum = 100;
        }
        static void initRefNum(ref int addNum)
        {
            addNum = 100;
        }
        static void Main(string[] args)
        {
            int a, b;

            initNum(out a); // a = 100;
            Console.WriteLine("a: {0}", a);

            b = 0;
            initRefNum(ref b); // ref로 사용하면 에러 발생 - error CS0165: 할당되지 않은 'b' 지역 변수를 사용했습니다.
            Console.WriteLine("b: {0}", b);
        }
    }
}
