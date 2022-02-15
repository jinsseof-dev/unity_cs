using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _094_Check
{
    class CSaveNumber
    {
        private int number1 { get; set; }
        private int number2 { get; set; }

        public CSaveNumber()
        {
            this.number1 = 0;
            this.number2 = 0;
        }
        public int InputNumber(int count)
        {
            if (count == 0)
            {
                Console.Write("첫번째 수를 입력해 주세요: ");
                this.number1 = int.Parse(Console.ReadLine());
                return this.number1;
            }
            else if (count == 1)
            {
                Console.Write("두번째 수를 입력해 주세요: ");
                this.number2 = int.Parse(Console.ReadLine());
                return this.number2;
            }
            else
            {
                return 0;
            }
        }
        public void PrintResult()
        {
            Console.WriteLine("{0} + {1} = {2}", this.number1, this.number2, (this.number1 + this.number2));
        }
    }
    internal class Program
    {
        static bool CheckEnd(int index)
        {
            bool isEnd = false;

            while (true)
            {
                Console.Write("{0}번째 추가로 계산할까요?(1: OK, 0: NO, 단 총 10번까지 가능)", (index+1));
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
            CSaveNumber[] saveNumbers = new CSaveNumber[COUNT];

            while (true)
            {
                saveNumbers[count] = new CSaveNumber();
                saveNumbers[count].InputNumber(0);
                saveNumbers[count].InputNumber(1);

                saveNumbers[count].PrintResult();

                if (count == 9 || !CheckEnd(count))
                {
                    for (int i = 0; i < count; i++)
                    {
                        saveNumbers[i].PrintResult();
                    }
                    break;
                }
                count++;
            }

        }
    }
}
