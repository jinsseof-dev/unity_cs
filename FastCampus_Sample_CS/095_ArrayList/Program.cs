using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _095_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add("Hello");
            arrList.Add(10f);

            for (int i = 0; i < 10; i++)
            {
                arrList.Add(i);
            }

            foreach (object data in arrList)
            {
                Console.WriteLine("arrList data: {0}", data);
            }

            // 배열 데이터로 초기화
            Console.WriteLine("배열 데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            ArrayList arrCopyList = new ArrayList(arrData);

            foreach(object data in arrCopyList)
            {
                Console.WriteLine("arrCopyList data: {0}", data);
            }
        }
    }
}
