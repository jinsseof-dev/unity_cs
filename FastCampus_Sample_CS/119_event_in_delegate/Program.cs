using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119_event_in_delegate
{
    public delegate void delegateEvent(string msg); // string을 파라미터로 하는 delegate를 생성합니다.

    class InDelegate
    {
        public delegateEvent myDelegate;    // delegate 멤버를 public으로 선언했습니다.
        public event delegateEvent myEvent; // event 멤버를 public으로 선언했습니다.
        public void DoEvent (int a, int b) // 이벤트 method를 생성했습니다.
        {
            if (null != myEvent) // event가 없을 경우에 대한 예외 처리. 항상 null 체크 필요합니다.
            {
                myEvent("DoEvent: " + (a + b)); // 이벤트 method를 파라미터를 넘겨서 호출합니다.
                                                // myEvent는 넘겨진 함수 이름입니다.
            }
        }
    }
    internal class Program
    {
        static public void ConsoleFunc(string msg) // Example에서 호출할 ConsoleFunc 함수입니다.
        {
            Console.WriteLine("ConsoleFunc: {0}", msg);
        }
        static void Main(string[] args)
        {
            InDelegate id = new InDelegate();             // InDelegate 클래스의 객체를 생성했습니다.
            id.myEvent += new delegateEvent(ConsoleFunc); // myEvent에 event 객체를 += 연산자로 대입합니다.
            id.myEvent = ConsoleFunc;       // [ERROR] 이벤트에 대입 연산자는 사용 불가합니다.
            id.myEvent += ConsoleFunc;      // 이벤트에 += 연산자는 사용 가능합니다.

            id.myDelegate = ConsoleFunc;    // 델리게이트는 대입 연산자 사용 가능합니다.
            id.myDelegate += ConsoleFunc;   // 델리게이트는 += 연산자도 사용 가능합니다.

            id.myDelegate("Test");          // delegate는 클래스 외부에서 직접 호출 가능합니다.
            id.myEvent("Test");             // [ERROR] event는 클래스 외부에서 직접 호출 불가합니다.
            
            for (int i=0;i<10;i++)
            {
                id.DoEvent(i + 1, i + 2); // DoEvent method를 불러서 method를 호출했습니다.
                                          // DoEvent는 내부에서 ConsoleFunc가 추가된 myEvent,
                                          // 즉 ConsoleFunc("DoEvent: " + (a + b))가 실행됩니다.
            }
        }
    }
}
