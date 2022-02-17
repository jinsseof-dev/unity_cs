using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _098_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("pos", 10);
            hashTable.Add("name", "Jack");
            hashTable["weight"] = 10.8;

            foreach (object key in hashTable.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, hashTable[key]);
            }

            Console.WriteLine();

            Hashtable hashTableCopy = new Hashtable()
            {
                ["pos"] = 1090,
                ["name"] = "Jane",
                ["weight"] = 1014.8f,
            };

            foreach (object key in hashTableCopy.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, hashTableCopy[key]);
            }
        }
    }
}
