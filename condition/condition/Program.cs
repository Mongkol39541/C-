using System;

namespace condition
{
    class Program
    {
        static void Main()
        {
            int var;
            Console.Write("Input : ");
            int.TryParse(Console.ReadLine(), out var);
            if(var >= 60)
            {
                Console.Write("Hello World!");
            }
            else
            {
                Console.Write("Hi");
            }
            Console.ReadKey();
        }
    }
}
