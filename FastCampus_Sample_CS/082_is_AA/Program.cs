using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _082_is_AA
{
    // Base 클래스를 선언하고, private 멤버 변수 a, Print() 함수를 선언하였습니다.
    class Base
    {
        int num;
        public void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }
    // Base 클래스를 상속하는 클래스 AA를 선언하였습니다. 변수, 함수 각각 1개를 선언하였습니다.
    class AA : Base
    {
        int a;
        public void PrintA()
        {
            Console.WriteLine("a: {0}", a);
        }
    }
    // Base 클래스를 상속하는 클래스 BB 선언하였습니다. 변수, 함수 각각 1개를 선언하였습니다.
    class BB : Base
    {
        int b;
        public void PrintB()
        {
            Console.WriteLine("b: {0}", b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base _base = new Base(); // Base 클래스의 객체를 생성하여 Base형 변수 _base에 담습니다.
            _base.Print();           // 이 객체는 Base의 method인 Print()를 호출할 수 있으므로 Base 클래스의 객체임이 확실합니다.

            Base aa = new AA();      // AA 클래스의 객체를 생성하여 Base형 변수 AA에 담습니다. 클래스는 다르지만, AA가 Base의 자식 클래스이므로 문제되지 않습니다.
            aa.Print();              // aa는 Base 클래스의 자식 클래스이므로 부모의 method를 호출할 수 있습니다.

            // 변수 aa를 is 키워드로 각각 Base, AA, BB의 클래스인지 검사합니다.
            if (aa is BB) // false
            {
                Console.WriteLine("aa는 BB의 객체 입니다.");
            }
            if (aa is AA) // true
            {
                Console.WriteLine("aa는 AA의 객체 입니다.");
            }
            if (aa is Base) // true
            {
                Console.WriteLine("aa는 Base 객체 입니다.");
            }


            Base bb = new BB();   // BB 클래스의 객체를 생성하여 Base형의 변수 bb에 담습니다.
            BB copyBB = bb as BB; // bb를 as 키워드를 사용하여 BB 클래스로 변환해 보았습니다.
            if (null != copyBB)   // 강제 형변환된 copyBB에는 BB 클래스의 객체가 반환되어 if문이 실행되었습니다.
            {
                Console.WriteLine("----");
                Console.WriteLine("copyBB는 BB 객체를 형식 변환");
                copyBB.PrintB();  // copyBB는 BB 클래스의 객체이므로 PrintB()를 호출 할 수 있습니다.
            }
            
            AA copyAA = bb as AA; // bb를 as 키워드를 사용하여 AA 클래스로 변환해 보았습니다.
            if (null == copyAA)   // 강제 형변환된 copyAA에는 null이 반환되어 대입되었습니다. AA와 BB 클래스간 상속 관계가 성립되지 않으므로 형변환이 불가합니다.
            {
                Console.WriteLine("----");
                Console.WriteLine("copyAA는 AA 객체가 아니므로 null");

                copyAA = new AA(); // copaAA에 새롭게 AA 객체를 생성하여 대입합니다.
                copyAA.Print();    // AA의 부모 클래스의 method가 정상 호출됩니다.
                copyAA.PrintA();   // AA의 클래스의 method가 정상 호출됩니다.

            }

        }
    }
}
