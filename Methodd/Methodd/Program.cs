using System;

namespace Methodd
{
    class Program
    {
        /*static void MyMethod1(int x)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", x, i, x*i);
            }
        }
        static void Main(string[] args)
        {
            for(int j = 2; j <= 12; j++)
            {
                MyMethod1(j);
            }
            Console.ReadKey();
        }*/
        static int inputNumber(int x,int y)
        {
            return x + y;
        }
        static void Main()
        {
            int i;
            int.TryParse(Console.ReadLine(), out i);
            int j;
            int.TryParse(Console.ReadLine(), out j);
            Console.WriteLine(inputNumber(i,j));
            Console.ReadKey();
        }
    }
}
