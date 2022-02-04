using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_Arry_Multi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNum = new int[3, 2];
            int[,] arrNum1 = new int[,] { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            int[,] arrNum2 = new int[3, 2] { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            int[,] arrNum3 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            arrNum[0, 0] = 1;
            arrNum[0, 1] = 2;

            arrNum[1, 0] = 3;
            arrNum[1, 1] = 4;

            arrNum[2, 0] = 5;
            arrNum[2, 1] = 6;

            foreach (int temp in arrNum)
            {
                Console.Write(" {0} ", temp);
            }
        }
    }
}
