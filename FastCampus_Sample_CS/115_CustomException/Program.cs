using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115_CustomException
{
    class MyException : ApplicationException
    {
        public int Num { get; set; }
        public MyException() : base()
        {
        }
        public MyException(int a) // 생성자 재정의도 가능합니다.
        {
            Num = a;
        }
        public override string ToString() // 기본 제공되는 ToString() method를 재정의하여 쓸 수 있습니다.
        {
            return "Num: " + Num;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요(0, 10은 예외 던짐): ");
            string readStr = Console.ReadLine();
            try
            {
                int num = int.Parse(readStr);

                if (num == 0 || num == 10)
                {
                    throw new MyException(num);
                }
            }
            catch (MyException e) when (e.Num == 0)
            {
                Console.WriteLine("when(e.Num == 0)");
                Console.WriteLine("MyException: {0}", e.Num);
                Console.WriteLine("MyException: {0}", e.StackTrace);
            }
            catch (MyException e) when (e.Num == 10)
            {
                Console.WriteLine("when(e.Num == 10)");
                Console.WriteLine("MyException: {0}", e.Num);
                Console.WriteLine("MyException: {0}", e.StackTrace);
            }
        }
    }
}
