using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0;
            bool isCorrect = false;

            while(!isCorrect)
            {
                string readStr = Console.ReadLine();
                try
                {
                    inputNum = int.Parse(readStr);
                    isCorrect = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("입력문자: {0} - 정수를 입력하세요", readStr);
                }
            }
            Console.WriteLine("inputNum: {0}", inputNum);
        }
    }
}
