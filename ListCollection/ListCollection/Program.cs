using System;
using System.Collections.Generic;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> customer = new List<string>();
            customer.Add("Magi");
            customer.Add("Boss");
            customer.Insert(1, "Zero");
            foreach(string Str in customer)
            {
                Console.WriteLine(Str);
            }
            Console.ReadKey();
        }
    }
}