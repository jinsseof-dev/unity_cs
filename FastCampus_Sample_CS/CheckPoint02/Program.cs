using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckPoint02
{
    internal class Program
    {
        const string LINE = "--------------------------------------------";
        const int END_LINE = 44;
        const int DELAY_TIME = 200;

        static int runA = 0;
        static int runB = 0;
        static int runC = 0;
        static int runD = 0;

        static void clearScreen()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }
        static void Process(Random random)
        {
            runA += random.Next(0, 4);
            runB += random.Next(0, 4);
            runC += random.Next(0, 4);
            runD += random.Next(0, 4);
        }

        static void UpdateScreen()
        {
            Console.WriteLine(LINE);
            for (int i = 0; i < runA; i++)
            {
                Console.Write(" ");
            }
            Console.Write("1");
            for (int i = END_LINE - 2 - runA; i >= 0; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            for (int i = 0; i < runB; i++)
            {
                Console.Write(" ");
            }
            Console.Write("2");
            for (int i = END_LINE - 2 - runB; i >= 0; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            for (int i = 0; i < runC; i++)
            {
                Console.Write(" ");
            }
            Console.Write("3");
            for (int i = END_LINE - 2 - runC; i >= 0; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            for (int i = 0; i < runD; i++)
            {
                Console.Write(" ");
            }
            Console.Write("4");
            for (int i = END_LINE - 2 - runD; i >= 0; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            Console.WriteLine(LINE);
        }

        static bool CheckResult()
        {
            if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
            {
                string strResult = "결과: !!{0}번 선수 우승!!!";
                string runNum = "";
                if (runA >= END_LINE)
                {
                    runNum = "1";
                }
                else if (runB >= END_LINE)
                {
                    runNum = "2";
                }
                else if (runC >= END_LINE)
                {
                    runNum = "3";
                }
                else if (runD >= END_LINE)
                {
                    runNum = "4";
                }
                Console.WriteLine(strResult, runNum);
                Console.Write("다시 하시려면 0번 입력");
                if ("0" == Console.ReadLine())
                {
                    runA = 0;
                    runB = 0;
                    runC = 0;
                    runD = 0;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {
                clearScreen();

                Process(random);
                UpdateScreen();

                if (!CheckResult())
                {
                    break;
                }
            }

        }
    }
}
