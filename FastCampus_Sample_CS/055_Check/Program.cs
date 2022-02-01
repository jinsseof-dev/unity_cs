using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int result = 0;


            Console.Write("총 몇회의 게임을 하시겠습니까?? ");
            int question = int.Parse(Console.ReadLine());


            for (int i=0;i< question; i++)
            {
                int num1 = rnd.Next(1, 100);
                int num2 = rnd.Next(1, 100);
                
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제 중 {1}번째)", (i + 1), (i + 1));
                Console.Write("{0} + {1} = ?? : ", num1, num2);
                int input = int.Parse(Console.ReadLine());

                if (input == (num1 + num2))
                {
                    Console.WriteLine("==정답==");
                    result++;
                }
                else
                {
                    Console.WriteLine("==오답==정답은 {0}", (num1 + num2));
                }
            }
            Console.WriteLine("총 {0} 문제 중 정답은 {1}회 입니다!!", question, result);
        }
    }
}
