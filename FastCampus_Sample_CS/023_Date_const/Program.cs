using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Date_const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            const int MIN = 1;

            Console.WriteLine("MIN: {0} ~ Max: {1}", MIN, MAX);

            // MAX = 1000; // Error
        }
    }
}
