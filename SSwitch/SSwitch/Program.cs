using System;

namespace SSwitch
{
    class Program
    {
        static void Main()
        {
            int ans;
            int.TryParse(Console.ReadLine(), out ans);
            switch (ans)
            {
                case 50:
                    Console.WriteLine("Hello World!");
                    break;
                default:
                    Console.WriteLine("Hi");
                    break;
            }
            Console.ReadKey();
        }
    }
}
