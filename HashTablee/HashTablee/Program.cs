using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTablee
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable prduct = new Hashtable();
            prduct.Add("P001", "Iphone");
            prduct.Add("P002", "SAMSUNG");
            prduct.Add("P003", "OPPO");

            foreach(string id in prduct.Values)
            {
                Console.WriteLine(id);
            }
            Console.ReadKey();
        }
    }
}
