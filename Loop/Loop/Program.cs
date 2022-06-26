using System;

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int ans;
            int.TryParse(Console.ReadLine(), out ans);
            //while
            while (ans < 11)
            {
                Console.WriteLine("While"+ans);
                ans++;
            }
            //do-while
            do
            {
                Console.WriteLine("Do" + ans);
                ans++;
                continue;
            }
            while (ans < 15);
            //for
            for (int i = 10; i > 1; i--)
            {
                Console.WriteLine("For"+i);
                break;
            }
            Console.ReadKey();
        }
    }
}
