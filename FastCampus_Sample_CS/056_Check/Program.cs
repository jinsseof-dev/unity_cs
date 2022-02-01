using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(1, 100);
            int tried = 0;
            bool is_result = false;

            while (is_result == false)
            {
                tried++;
                Console.Write("1~99 사이 어떤 숫자일까요?(단, 0은 나가기) : ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("0이 입력되어 프로그램을 종료합니다.");
                    is_result = true;
                }
                else if (input > 99 || input < 0)
                {
                    Console.WriteLine("﻿1-99 범위의 숫자를 입력해주세요");
                }
                else if (input > answer)
                {
                    Console.WriteLine("입력한 수는 커요");
                }
                else if (input < answer)
                {
                    Console.WriteLine("입력한 수는 작아요");
                }
                else
                {
                    Console.WriteLine("==정답== 총 시도 횟수는 {0}회 입니다.", tried);
                    is_result = true;
                }
            }
        }
    }
}
