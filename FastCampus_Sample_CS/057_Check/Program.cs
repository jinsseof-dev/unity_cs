using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;

            for(int i=0;i<5;i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                int input = int.Parse(Console.ReadLine());

                sum += input;

                if (input > max)
                {
                    max = input;
                }
                if (input < min)
                {
                    min = input;
                }
            }
            Console.WriteLine("최댓값: {0}, 최솟값: {1}, 평균값: {2}", max, min, sum/5);
        }
    }
}
