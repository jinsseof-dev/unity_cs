using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073_Array_Func2
{
    internal class Program
    {
        static int[] CreateIntArray(int size)
        {
            int[] initArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                initArray[i] = 0;
            }
            return initArray;
        }
        static int[,] CreateIntArray(int row, int col)
        {
            int[,] initArray = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    initArray[i,j] = 0;
                }
            }
            return initArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------");
            int[] arrNum = CreateIntArray(3);
            foreach (int temp in arrNum)
            {
                Console.Write(" {0} ", temp);
            }
            Console.WriteLine("\n--------");
            Console.WriteLine("\n--------");
            int[,] arrNum1 = CreateIntArray(3, 4);
            foreach (int temp in arrNum1)
            {
                Console.Write(" {0} ", temp);
            }
            Console.WriteLine("{0}", arrNum1.GetType());
            Console.WriteLine("\n--------");

        }
    }
}
