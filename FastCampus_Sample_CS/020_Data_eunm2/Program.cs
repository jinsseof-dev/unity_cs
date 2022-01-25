using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Data_eunm2
{
    internal class Program
    {
        enum CHAR_STATE
        {
            IDLE, // 0
            WALK, // 1
            RUN,  // 2
            DIE,  // 3
        }

        enum CLICK_STATE
        {
            NONE,               // 0
            CLICK = 100,        // 100
            DOUBLE_CLICK = 200, // 200
            UP,                 // 201
        }
        static void Main(string[] args)
        {
            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("캐릭터 상태: {0} {1}", charState, (int)charState);

            charState = CHAR_STATE.RUN;
            Console.WriteLine("캐릭터 상태: {0} {1}", charState, (int)charState);

            charState = CHAR_STATE.DIE;
            Console.WriteLine("캐릭터 상태: {0} {1}", charState, (int)charState);

            
        }
    }
}
