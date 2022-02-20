using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112_Exception_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 10;

            try
            {
                checked
                {
                    maxNum += Int32.MaxValue;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("e.Message: {0}", e.Message);
                Console.WriteLine("e.Source: {0}", e.Source);
            }
            catch (Exception e)
            {
                Console.WriteLine("e.Message: {0}", e.Message);
            }

            Console.WriteLine("maxNum: {0}", maxNum);

        }
    }
}
