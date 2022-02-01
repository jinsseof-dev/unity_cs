using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_Operator_branch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isA = false;
            bool isB = true;
            bool isC = true;
            bool isD = false;

            if(isB && isC)
            {
                Console.WriteLine("true && true => {0}", (isB && isC));
            }

            if(isC || isD)
            {
                Console.WriteLine("true || false => {0}", (isC || isD));
            }

            if (2 > 1 && 3 < 4 || 1 > 2) // 복합적으로 사용된 경우에는 앞에서부터 차례대로
            {
                Console.WriteLine("true && true || false => {0}", (2 > 1 && 3 < 4 || 1 > 2));
            }
        }
    }
}
