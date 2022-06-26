using System;

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int Age;
            int.TryParse(Console.ReadLine(),out Age);
            Console.WriteLine("My name is {0} age = {1} year",name,Age);
            Console.ReadKey();
        }
    }
}
