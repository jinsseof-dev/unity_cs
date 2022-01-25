using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Data8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            int num = a;

            Console.WriteLine("문자: {0}, 아스키코드: {1}, 문자로 캐스트 연산: {2}", a, num, (char)num);
        }
    }
}
