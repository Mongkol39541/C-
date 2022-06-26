using System;

namespace Arrayy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Magi", "Zero", "Boss", "Kira" };
            for (int num = 0; num < 4; num++)
            {
                Console.Write(name[num]);
                Console.WriteLine(num);
            }
            foreach(string i in name)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}