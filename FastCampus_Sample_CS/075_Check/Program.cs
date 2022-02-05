using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_Check
{
    internal class Program
    {
        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요: ");
            ID[index] = int.Parse(Console.ReadLine());
        }

        static void InputKor(int[] kor, int index)
        {
            Console.Write("국어 점수를 입력하세요: ");
            kor[index] = int.Parse(Console.ReadLine());
        }

        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요: ");
            math[index] = int.Parse(Console.ReadLine());
        }

        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요: ");
            eng[index] = int.Parse(Console.ReadLine());
        }

        static void PrintID(int max, int[] ID)
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("학생 ID: {0}", ID[i]);
            }
        }

        static int CheckID(int id, int max, int[] ID)
        {
            for (int i = 0; i < max; i++)
            {
                if (ID[i] == id)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int id = 0;
            int max = 3;
            int[] kor = new int[3];
            int[] math = new int[3];
            int[] eng = new int[3];
            int[] ID = new int[3];
            int index = 0;


            for (int i=0;i<max;i++)
            {
                InputID(ID, i);
                InputKor(kor, i);
                InputMath(math, i);
                InputEng(eng, i);
            }


            while (true)
            {
                PrintID(max, ID);
                Console.Write("학생 ID를 입력하세요(0 - 나가기): ");
                id = int.Parse(Console.ReadLine());
                index = CheckID(id, max, ID);

                if (id == 0) {
                    break;
                }
                else if (index == -1)
                {
                    Console.WriteLine("학생의 ID가 없어요. 다시 입력하세요");
                }
                else
                {
                    Console.WriteLine("국어 점수: {0}", kor[index]);
                    Console.WriteLine("수학 점수: {0}", math[index]);
                    Console.WriteLine("영어 점수: {0}", eng[index]);

                    int total = (kor[index] + math[index] + eng[index]);
                    Console.WriteLine("총점: {0}", total);
                    Console.WriteLine("평균: {0}", (float)(total / 3));
                }
            }
        }
    }
}
