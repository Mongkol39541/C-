using System;

namespace Exceptionn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 25;
                int y = 0;
                double z = x / y;
                Console.WriteLine(z);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End Program");
            }
            Console.ReadKey();
        }
    }
}
