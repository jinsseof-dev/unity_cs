using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _099_Indexor01
{
    class AA
    {
        private int[] num = new int[10];

        public int this[int index]
        {
            get { return num[index]; }
            set { num[index] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();

            for (int i= 0; i < 10; i++)
            {
                aa[i] = i;
            }

            aa[0] = 10;
            aa[1] = 200;
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("aa[{0}]: {1}", i, aa[i]);
            }
        }
    }
}
