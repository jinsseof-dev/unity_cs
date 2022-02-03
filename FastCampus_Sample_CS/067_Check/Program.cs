using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_Check
{
    internal class Program
    {
        // 성적 프로그램 시작
        static void Start()
        {
            Console.WriteLine("성적 프로그램 - Method");
        }

        // 성적 입력
        static void Input(ref int kor, ref int mat, ref int eng)
        {
            Console.Write("국어 성적 입력(정수): ");
            kor = int.Parse(Console.ReadLine());

            Console.Write("수작 성적 입력(정수): ");
            mat = int.Parse(Console.ReadLine());

            Console.Write("영어 성적 입력(정수): ");
            eng = int.Parse(Console.ReadLine());

            Console.WriteLine("kor: {0}, mat: {1}, eng: {2}", kor, mat, eng);
        }

        // 입력한 성적 합
        static int TotalSum(int kor, int mat, int eng)
        {
            return kor + mat + eng;
        }

        // 성적의 평균
        static void Average(int total, out float average)
        {
            average = total / 3;
        }
        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;
            int total;
            float average;

            Start();
            Input(ref kor, ref mat, ref eng);
            total = TotalSum(kor, mat, eng);

            Average(total, out average);
            Console.WriteLine("Total: {0}    Average: {1}", total, average);

        }
    }
}
