using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_Array_Init2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrNum = new int[3];
            int[] arrNum1 = new int[] { 0, 1, 2 };
            int[] arrNum2 = new int[3] { 0, 1, 2 };
            int[] arrNum3 = { 0, 1, 2 };

            string[] arrWeek = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};

            for(int i=0;i<arrNum.Length; i++)
            {
                arrNum[i] = i;
            }

            Console.WriteLine("\n-----------");
            for (int i=0;i<arrNum.Length;i++)
            {
                Console.Write(" {0} ", arrNum[i]);
            }

            Console.WriteLine("\n-----------");

            foreach(string value in arrWeek)
            {
                Console.Write(" {0} ", value);
            }
            Console.WriteLine("\n-----------");
        }
    }
}
