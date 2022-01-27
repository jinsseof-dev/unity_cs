using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_Data_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strA = "100";
            string strB = "3.141593";
            string strC = "3.141592653589732384626433832";

            int parseA = int.Parse(strA);
            float parseB = float.Parse(strB);
            decimal parseC = decimal.Parse(strC);

            Console.WriteLine("a.ToString(): {0}\n a.ToString().GetType(): {1}", parseA, parseA.GetType());
            Console.WriteLine("b.ToString(): {0}\n b.ToString().GetType(): {1}", parseB, parseB.GetType());
            Console.WriteLine("c.ToString(): {0}\n c.ToString().GetType(): {1}", parseC, parseC.GetType());
        }
    }
}
