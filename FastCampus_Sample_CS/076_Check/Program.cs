using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_Check
{
    internal class Program
    {
        static int InputNumber(int count)
        {
            if (count == 0)
            {
                Console.Write("첫번째 수를 입력해 주세요: ");
                return int.Parse(Console.ReadLine());
            }
            else if (count == 1)
            {
                Console.Write("두번째 수를 입력해 주세요: ");
                return int.Parse(Console.ReadLine());
            }
            else
            {
                return 0;
            }
        }
        static void PrintResult(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }
        static bool CheckEnd()
        {
            while (true)
            {
                Console.Write("추가로 계산할까요?(1: OK, 0: NO, 단 총 10번까지 가능)");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    return true;
                }
                else if (input == 0)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                }
            }
        }
        static void Main(string[] args)
        {
            const int COUNT = 10;
            int count = 0;
            int[,] number = new int[COUNT, 2];

            for (int i = 0; i < COUNT; i++)
            {
                count++;
                number[i, 0] = InputNumber(0);
                number[i, 1] = InputNumber(1);
                PrintResult(number[i, 0], number[i, 1]);

                if (i == 9 || !CheckEnd())
                {
                    break;
                }
            }

            for (int i = 0; i < count; i++)
            {
                PrintResult(number[i, 0], number[i, 1]);
            }
        }
    }
}
