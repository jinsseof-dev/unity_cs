using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Data3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sbyteData = 255;
            sbyte sbyteData1 = (sbyte)sbyteData; // 캐스트 연산 오류
            int num = (int)sbyteData; // 명시적 형변환
            int num1 = sbyteData; // 묵시적 형변환

            Console.WriteLine("sbyteData : {0}", sbyteData);
            Console.WriteLine("sbyteData1 : {0}", sbyteData1); // overflow 발생
            Console.WriteLine("sbyte.MaxValue : {0}", sbyte.MaxValue);
            Console.WriteLine("num : {0}", num);
            Console.WriteLine("num1 : {0}", num1);
        }
    }
}
